using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour {
	
	public string[] names;

	void OnEnable(){
		Debug.Log ("I am Enabled");
	}
	void OnDisable(){
		
		Debug.Log ("The people who work at Razeware are: ");
		Debug.Log (names [0]);
		Debug.Log (names [1]);
		Debug.Log (names [2]);
		Debug.Log (names [3]);
		Debug.Log (names [4]);
	}
}
