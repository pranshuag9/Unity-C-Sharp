using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MabLibs : MonoBehaviour {

	public string myName = "Pranshu";
	public string favouriteFood = "Manchurian";
	public double amount = 5;
	public bool likesToShare = false;

	void OnDisable(){
		Debug.Log ("I am " + myName + " and my Favourite food is " + favouriteFood + ".");
	}
	void OnEnable(){
		Debug.Log ("I am Enabled");
	}
}
