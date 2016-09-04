using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour {
	
	public GameObject player;
	private Vector3 offset;
	public float yrotation;

	void Start () 
	{
		offset = transform.position - player.transform.position;
	}

	void Update(){
	}

	void LateUpdate () 
	{
		transform.position = player.transform.position + offset;
	}

}
