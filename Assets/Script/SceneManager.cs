using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartSea(){
//		SceneManager.LoadScene ("StageSea");
		Application.LoadLevel("StageSea");
	}

	public void Restart(){
		Application.LoadLevel("Start");
	}


}
