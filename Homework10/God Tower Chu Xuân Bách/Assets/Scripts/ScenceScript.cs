using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScenceScript : MonoBehaviour {

	public Text levelText;
	public InputField inputField;
	public Button summitButton;
	public Text HintText;

	public string levelContent = "LEVELS";
	public string levelnumber;
	public string levelAnswer;

	string answer;


	public int SceneIndex = 1;
	// Use this for initialization

	public int NextSceneIndex;

	void Start () {
		levelText.text = levelContent;
		StartCoroutine (ChangeLevelTextRoutine ());
	}



	public void getInput(){
		answer = inputField.text;
		CheckAnswer (answer);
	}

	public void CheckAnswer(string answer){
		if (answer.ToLower() == levelAnswer) {
			HintText.text = "Yayyyyyyyy !!";
			SceneManager.LoadScene (NextSceneIndex);
			return;
			//TODO: Change Scene

		}else{
			HintText.text = "WRONG !!!!";
			HintText.color = Color.red;
			inputField.text = "";
			inputField.ActivateInputField ();
		}
	}


	IEnumerator ChangeLevelTextRoutine(){
		while (true) {
			levelText.text = levelContent;
			yield return new WaitForSeconds (2f);
			levelText.text = levelnumber;
			yield return new WaitForSeconds (2f);
		}
	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
