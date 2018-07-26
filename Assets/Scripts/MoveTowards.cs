using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour {

public Transform target;
public float speed;
public float timer = 0f;
//public GameObject astronaut;

	void Update() {

		    //den Astronauten spawnen lassen

		 /*timer += Time.deltaTime; 

		if (timer >= 60) 
		{
			Instantiate (astronaut, new Vector3 (500, 300, -130), Quaternion.identity);*/

		//Astronaut bewegt sich auf Astronaut(1) zu

		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);

		}
}
