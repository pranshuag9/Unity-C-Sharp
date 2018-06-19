using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour {
	//Defining the variables to be used
	public double balance = 2000;
	public double percentageOfTheTip=2;
	public double tip;
	//Defining the function to be performed on click Enable
	void OnEnable(){
		Debug.Log ("I am Enabled");
	}
	//Defining the function to be performed on click Disable
	void OnDisable(){
		tip = ((balance / 100) * percentageOfTheTip);
		Debug.Log ("Tip = " + tip);
	}

}
