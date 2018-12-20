using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomFillLava : MonoBehaviour {

   // public GameObject lavaSpawn;
    private Vector3 pos;
    Quaternion rot;
    private GameObject player;
    public GameObject rock;
    //public GameObject lavaFill;
    public bool blocked;
    public GameObject spawnObject;
    private float x;
    private float y;
    private float z;
    private int layer;


    // Use this for initialization
    void Start ()
    {
        blocked = true;
        layer = 0;
        player = GameObject.FindWithTag("MainCamera");
        rot = spawnObject.transform.rotation;
        y = spawnObject.transform.position.y;       
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (!blocked & layer < 7)
        {
            AddLavaLayer();
        }

        if(!blocked & layer >= 7)
        {
            blocked = true;
         }
	}
		
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            blocked = false;
        }
    }
        
    public void AddLavaLayer()
    {
        layer++;
        pos = new Vector3(-830.9f, y + layer, -151.9f);
        GameObject obj = Instantiate(spawnObject, pos, rot) as GameObject;
    }
}
