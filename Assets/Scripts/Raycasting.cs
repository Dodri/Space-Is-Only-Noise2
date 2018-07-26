using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {

		RaycastHit hit;
		float TheDistance;
		//Debug Raycast in Editor, so we can see it 
		Vector3 forward = transform.TransformDirection (Vector3.forward) * 1000;
		Debug.DrawRay (transform.position, forward, Color.green);

		if(Physics.Raycast(transform.position,(forward), out hit)) {
			
			TheDistance = hit.distance; 
			print (TheDistance + " " + hit.collider.gameObject.name);
	}
}
}
