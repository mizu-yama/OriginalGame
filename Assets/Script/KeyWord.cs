using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyWord : MonoBehaviour {

	public Text keywordA, keywordB;
	public Text stageanswerA, stageanswerB;
	public Text answerA, answerB;
	public GameObject panelanswerA, panelfinishA, paneloutA;
	public GameObject panelanswerB, panelfinishB, paneloutB;

	// Use this for initialization
	void Start () {
		decide ();
	}
		
	void decide(){
//		KeyWordsDate.numberA = Random.Range (0, KeyWordsDate.keywords.Length);
//		KeyWordsDate.numberB = Random.Range (0, KeyWordsDate.keywords.Length);
		keywordA.text = KeyWordsDate.keywords [KeyWordsDate.numberA].ToString();
		keywordB.text = KeyWordsDate.keywords [KeyWordsDate.numberB].ToString();
		stageanswerA.text = KeyWordsDate.answers [0, KeyWordsDate.numberB].ToString();
		stageanswerB.text = KeyWordsDate.answers [0, KeyWordsDate.numberA].ToString();
	}

	public void AAnswer(){
		if (answerA.text == keywordB.text) {
			panelanswerA.SetActive (false);
			panelfinishA.SetActive (true);
		} else {
			panelanswerA.SetActive (false);
			paneloutA.SetActive (true);
		}
	}

	public void BAnswer(){
		if (answerB.text == keywordA.text) {
			panelanswerB.SetActive (false);
			panelfinishB.SetActive (true);
		} else {
			panelanswerB.SetActive (false);
			paneloutB.SetActive (true);
		}
	}

}

