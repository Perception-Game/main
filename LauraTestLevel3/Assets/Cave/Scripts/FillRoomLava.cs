using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillRoomLava : MonoBehaviour {

    private Vector3 pos;
    Quaternion rot;
    private GameObject player;
    public GameObject sphere;
    //public GameObject lavaFill;
    private bool close;
    public GameObject spawnObject;
   // private float x;
    //private float y;
    //private float z;
    private int layer;
	private float distance;
	public GameObject lion;
	public float minDistance = 2f;
	//public AudioClip lavaSound;
	//private AudioSource source;


    // Use this for initialization
    void Start ()
    {

     //   close = false;
        layer = 0;
        player = GameObject.FindWithTag("MainCamera");
        rot = spawnObject.transform.rotation;
		//source = GetComponent<AudioSource>();
        // x = spawnObject.transform.position.x;
       // y = spawnObject.transform.position.y;
        // z = spawnObject.transform.position.y;
    }

    // Update is called once per frame
    void Update ()
    {   
		distance = Vector3.Distance(sphere.transform.position, lion.transform.position);

		if (distance < minDistance && layer < 1)
		{
			AddLavaLayer();
			layer++;
			//source.PlayOneShot(lavaSound);

		}



       // if (close & layer < 1)
      //  {
            //  StartCoroutine(AddLavaLayer());
         //   AddLavaLayer();
      //  }
    }

   // private void OnTriggerEnter(Collider other)
   // {
     //   if (other.gameObject.tag == "Player")
     //   {
      //      close = true;
       // }
  //  }

    public void AddLavaLayer()
    {
        // yield return new WaitForSeconds(0);
        layer++;
		pos = new Vector3(-830.9f, 248.82f, -151.9f);
        GameObject obj = Instantiate(spawnObject, pos, rot) as GameObject;

		//y + layer
    }
}
