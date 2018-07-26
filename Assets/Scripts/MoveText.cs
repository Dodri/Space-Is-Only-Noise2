using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveText: MonoBehaviour {
	public float time = 43; //Seconds to read the text

	IEnumerator Start ()
	{
		yield return new WaitForSeconds(time);
		Destroy(gameObject);
	}
}
