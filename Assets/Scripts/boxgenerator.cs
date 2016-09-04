using UnityEngine;
using System.Collections;

public class boxgenerator : MonoBehaviour {

	public float SecondsPerSpawn;

	public GameObject saver;
	public GameObject helper;

	public GameObject spawnPoint1;
	public GameObject spawnPoint2;
	public GameObject spawnPoint3;
	public GameObject spawnPoint4;
	public GameObject spawnPoint5;
	public GameObject spawnPoint6;

	public GameObject fan;

	public GameObject box;

	void Start () {
		InvokeRepeating ("spawnallbox", 2, SecondsPerSpawn);
		InvokeRepeating ("spawnhelpbox", 3, 3);
		InvokeRepeating ("spawnSaver", 40, 40);
	}

	void spawnallbox() {
			spawn1 ();
			spawn2 ();
			spawn3 ();
			spawn4 ();
			spawn5 ();
			spawn6 ();
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

	void spawn4(){
		//Debug.Log ("spawn3");
		Instantiate (box, spawnPoint4.transform.position, box.transform.rotation);
	}

	void spawn5(){
		//Debug.Log ("spawn3");
		Instantiate (box, spawnPoint5.transform.position, box.transform.rotation);
	}

	void spawn6(){
		//Debug.Log ("spawn3");
		Instantiate (box, spawnPoint6.transform.position, box.transform.rotation);
	}


	void spawnSaver(){
		Instantiate (saver, spawnPoint3.transform.position, saver.transform.rotation);
	}

	void spawnhelpbox(){
		int rand = Random.Range (1, 7);
		if (rand == 1)
		Instantiate (helper, spawnPoint1.transform.position, saver.transform.rotation);
		else if (rand == 2)
			Instantiate (helper, spawnPoint2.transform.position, saver.transform.rotation);
		else if (rand == 3)
			Instantiate (helper, spawnPoint3.transform.position, saver.transform.rotation);
		else if (rand == 4)
			Instantiate (helper, spawnPoint4.transform.position, saver.transform.rotation);
		else if (rand == 5)
			Instantiate (helper, spawnPoint5.transform.position, saver.transform.rotation);
		else if (rand == 6)
			Instantiate (helper, spawnPoint6.transform.position, saver.transform.rotation);
	}

	public void killgenerator(){
		Destroy (gameObject);
	}
}
