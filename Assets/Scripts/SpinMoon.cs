using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinMoon : MonoBehaviour {

	public float speed = 10f;

	public float speed2 = 5f;

	public GameObject earth;

	void Update () {

		OrbitAround ();

		transform.Rotate (Vector3.up, speed * Time.deltaTime);

	}

	void OrbitAround() {
		transform.RotateAround (earth.transform.position, Vector3.up, speed2 * Time.deltaTime);
	}
}
