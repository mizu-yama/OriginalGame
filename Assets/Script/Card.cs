using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour {

	public string word;//表示される文字列
	public int questionIndex;//questionsのIndex（表の何番目か）
	public Text Label;//UIのラベル


	// Use this for initialization
	void Start () {
		questionIndex = Random.Range (0, KeyWordsDate.questions.Length);
		word = KeyWordsDate.questions [questionIndex];
		//questionIndexを選択したら、CSVのデータからwordの中身につっこむ
		Label.text = word;


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
