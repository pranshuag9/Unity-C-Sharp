using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Text;

public class HighScoreAverage : MonoBehaviour {
	public double size;
	public double[] highScore;
	public double highScoreAverage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnDisable () {
		double sum = 0;
		for (int i = 0; i < size; i++) {
			sum += highScore[i];
		}
		highScoreAverage = sum / size;
		Debug.Log ("Average of Highscore is: " + highScoreAverage);
	}
}
