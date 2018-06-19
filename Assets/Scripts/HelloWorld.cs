using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	public string gameName="Half Life";
	public int price=10;
	public string anotherGameName="Minecraft";
	public int score = 5;
	public double myDouble = 10.1;
	public float myFloat = 10.1f; // or (float) 10.1;
	public bool likesGame = false;

	public byte overflowError = 255;

	void OnDisable(){
		/*
		string gameName = "Half Life";
		int price = 10;
		Debug.Log ("The Game " + gameName + " is "+price+" dollars.");
		Debug.Log ("The Game " + anotherGameName + " is rated at " + score + " stars.");
		*/
		overflowError = (byte)(overflowError + 3);
		Debug.Log ("The result of overflowError is: " +overflowError);
	}
	void OnEnable(){
		Debug.Log ("I am Enabled");
	}
}
