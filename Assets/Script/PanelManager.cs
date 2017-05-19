using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour {

	int panelIndex = 0; //今表示しているpanelのindex
	public GameObject[] panels;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void ChangeIndex (int input){
		panelIndex = input;//引数のinputをpanelIndexに代入する
		Display();
	}
		

	//panelIndexのの番号のpanelを画面に表示する
	void Display(){
		//for文でiを0からpanelsの長さまで繰り返し1ずつ足していく
		for (int i = 0; i < panels.Length; i++) {
			if (i == panelIndex) {
				panels [i].SetActive (true);
			} else {
				panels [i].SetActive (false);
			}
		}
	}
}
