﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartSceneController : MonoBehaviour {

	public void OnBeginButtonClick(){
		SceneManager.LoadScene (1);
	}
		


}
