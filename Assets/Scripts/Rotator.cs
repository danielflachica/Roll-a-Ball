using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		// Time.deltaTime rotates the object per second, not per frame
		transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
