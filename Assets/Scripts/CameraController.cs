using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position; //camera position - player position
	}
	
	// Update is called once per frame
	// void Update () {
		
	// }

	// LateUpdate() runs every frame, but is guaranteed to run after all items have been processed in Update()
	void LateUpdate() {
		transform.position = player.transform.position + offset; //move camera with player
	}
}
