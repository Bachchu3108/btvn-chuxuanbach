using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lvl43Controller : MonoBehaviour {

	public Image barImage;

	void Start(){
		barImage = GetComponent<Image> ();
	}
	public void OnPointerEnter(){	
		Color temColor = barImage.color;
		temColor.a = 0;
		barImage.color = temColor;

	}

	public void OnPointerExit(){
		Color temColor = barImage.color;
		temColor.a = 1;
		barImage.color = temColor;
	}


}
