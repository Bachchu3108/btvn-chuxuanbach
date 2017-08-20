using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public Text displayText;
	public Button lowerButton;
	public Button correctButton;
	public Button higherButton;
	public Button playAgainButton;
	int guessNumber;
	string guess;
	int min = 0;
	int max = 100;
	int guessCount=0;


	// Use this for initialization
	void Start () {
		PlayAgain ();
	}
	public void guessANumber(){
		guessNumber = Random.Range (min, max);
		displayText.text = "Choose a number between " + min + " and " + max + ". Is it " + guessNumber + "???";
		guessCount = guessCount + 1;
		higherButton.gameObject.SetActive (true);
		lowerButton.gameObject.SetActive (true);
		correctButton.gameObject.SetActive (true);
		playAgainButton.gameObject.SetActive (false);	
	}

	public void lowerControll(){
		max = guessNumber - 1;
		guessNumber = Random.Range (min, max);			
		displayText.text = "Choose a number between " + min + " and " + max + ". Is it " + guessNumber + "???";
		guessCount = guessCount + 1;
		iff ();
	}
	public void higherControll(){
		min = guessNumber + 1;
		guessNumber = Random.Range (min, max);
		displayText.text = "Choose a number between " + min + " and " + max + ". Is it " + guessNumber + "???";
		guessCount = guessCount + 1;
		iff ();
	}
	public void correctAnswer(){
		playAgainButton.gameObject.SetActive (true);
		higherButton.gameObject.SetActive (false);
		lowerButton.gameObject.SetActive (false);
		displayText.text = "I need " + guessCount + " times to predict your number";

	}
	public void PlayAgain()
	{
		guessCount = 0;
		guessANumber ();	
	}
	public void iff(){
		if (min >= max) {
			displayText.text = "Your number must be " + guessNumber;
			higherButton.gameObject.SetActive (false);
			lowerButton.gameObject.SetActive (false);
		} else if (max == 1) {
			displayText.text = "Your number must be 0";
		} else if (min == 99) {
			displayText.text = "Your number must be 100";
		}
	}

}
