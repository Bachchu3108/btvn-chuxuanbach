using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HintChanger : MonoBehaviour {

//	public Image Hint1;
//	public Image Hint2;

	public List<Image> hintsList;
	public Button HintButton;

	int hintCurrentIndex = 1;

//	public void OnHintButtonClick(){
//		if (hintCurrentIndex == 1) {
//			Hint1.gameObject.SetActive (true);
//			Hint2.gameObject.SetActive (false);
//			hintCurrentIndex = 2;
//		} else {
//			Hint1.gameObject.SetActive (false);
//			Hint2.gameObject.SetActive (true);
//			hintCurrentIndex = 1;
//		}
//	}
	public void OnHintButtonClick(){
		hintCurrentIndex++;
		if (hintCurrentIndex == hintsList.Count - 1) {
			HintButton.transform.localScale = new Vector3 (-1, 1, 1);
		} else {
			HintButton.transform.localScale = new Vector3 (1, 1, 1);
		}
		if (hintCurrentIndex == hintsList.Count) {
			hintCurrentIndex = 0;
		}

		for (int i = 0; i < hintsList.Count; i++) {
			if (i == hintCurrentIndex) {
				hintsList [i].gameObject.SetActive (true);
			} else {
				hintsList [i].gameObject.SetActive (false);
			}
		}
	}

}
