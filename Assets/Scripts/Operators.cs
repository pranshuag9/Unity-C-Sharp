using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operators : MonoBehaviour {
	public int value = 0;

	void OnDisable(){
		//int x = ((100 / 4) * 20) + (3 * 2);
		//Debug.Log ("x is " + x);
		Debug.Log("Value is "+value%2);
	}
	void OnEnable(){
		Debug.Log ("I am Enabled");
	}

}
