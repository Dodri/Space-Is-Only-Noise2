using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateSlider : MonoBehaviour {

	public float myValue = 10; // the total
	public float subtractPerSecond = 1; // remove this every second

	public void Update() {
		//subtract at a constant rate
		myValue -= subtractPerSecond * Time.deltaTime;
	}
}