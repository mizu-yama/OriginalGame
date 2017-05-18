using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyWordsManager : MonoBehaviour {

	public Text keywordA, keywordB;

	// Use this for initialization
	void Start () {
		Debug.Log (KeyWordsDate.keywords [0]);
		keywordA.text = KeyWordsDate.keywords [0].ToString();
		keywordB.text = KeyWordsDate.keywords [5].ToString();



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
