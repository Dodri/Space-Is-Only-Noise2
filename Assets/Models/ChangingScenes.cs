using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingScenes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown (KeyCode.F2)) {
			Application.LoadLevel (1);
		
	}
}
}
