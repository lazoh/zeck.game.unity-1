using UnityEngine;
using System.Collections;

public class boxgenerator : MonoBehaviour {

	public float SecondsPerSpawn;

	public GameObject saver;
	public GameObject helper;

	public GameObject spawnPoint1;
	public GameObject spawnPoint2;
	public GameObject spawnPoint3;

	public GameObject fan;

	public GameObject box;

	void Start () {
		InvokeRepeating ("spawnallbox", 1, SecondsPerSpawn);
		InvokeRepeating ("spawnhelpbox", 3, 3);
		InvokeRepeating ("spawnSaver", 40, 40);
	}

	void spawnallbox() {
			spawn1 ();
			spawn2 ();
			spawn3 ();
		}


	void spawn1(){
		//Debug.Log ("Spawn1");
		Instantiate(box, spawnPoint1.transform.position, box.transform.rotation);
	}

	void spawn2(){
		//Debug.Log ("spawn2");
		Instantiate (box, spawnPoint2.transform.position, box.transform.rotation);
	}

	void spawn3(){
		//Debug.Log ("spawn3");
		Instantiate (box, spawnPoint3.transform.position, box.transform.rotation);
	}

	void spawnSaver(){
		Instantiate (saver, spawnPoint3.transform.position, saver.transform.rotation);
	}

	void spawnhelpbox(){
		int rand = Random.Range (1, 4);
		if (rand == 1)
		Instantiate (helper, spawnPoint1.transform.position, saver.transform.rotation);
		else if (rand == 2)
			Instantiate (helper, spawnPoint2.transform.position, saver.transform.rotation);
		else if (rand == 3)
			Instantiate (helper, spawnPoint3.transform.position, saver.transform.rotation);
		
	}

	public void killgenerator(){
		Destroy (gameObject);
	}
}
