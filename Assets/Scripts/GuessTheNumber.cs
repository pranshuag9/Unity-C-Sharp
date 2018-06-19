using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuessTheNumber : MonoBehaviour {
	int randomNumber;
	public int yourGuessedNumber;
	// Use this for initialization
	void OnEnable () {
		randomNumber = Random.Range (1, 10);
	}

	void OnDisable () {
		if (yourGuessedNumber < 1 || yourGuessedNumber > 10) {
			Debug.Log ("Please enter the number in the range 1-10");
		} else if (yourGuessedNumber > randomNumber) {
			Debug.Log ("Too High");
		} else if (yourGuessedNumber < randomNumber) {
			Debug.Log ("Too Low");
		} else {
			Debug.Log ("Hurray!You guessed right.");
		}
	}
}
