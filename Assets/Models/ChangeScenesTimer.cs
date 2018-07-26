using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ChangeScenesTimer : MonoBehaviour {

	public string levelLoad;
	public float timer = 140f;
	//private Text timerSeconds;
	public Color loadToColor = Color.black;


	// Use this for initialization
	void Start () {

//		timerSeconds = GetComponent<Text> ();

		
	}
	
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;
		//timerSeconds.text = timer.ToString ("f2");
		if (timer <= 0) {
			Initiate.Fade (levelLoad, loadToColor, 5f);
			Application.LoadLevel("black");		}
	}
	
}
