using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour {

	public string word;//表示される文字列
	public int questionIndex;//questionsのIndex（表の何番目か）
	public Text Label;//UIのラベル
	public Text SelectquestionA,SelectquestionB;
	public Text SelectedquestionAA,SelectedquestionAB;
	public Text SelectedquestionBA,SelectedquestionBB;
	public Text answerAA, answerAB, answerBA, answerBB;

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

	public void SelectA(){
		SelectquestionA.text = Label.text;
		SelectedquestionAA.text = Label.text;
		SelectedquestionBA.text = Label.text;
		answerAA.text = KeyWordsDate.answers [questionIndex, KeyWordsDate.numberB].ToString();
		answerBA.text = KeyWordsDate.answers [questionIndex, KeyWordsDate.numberA].ToString();
			
	}		

	public void SelectB(){
		SelectquestionB.text = Label.text;
		SelectedquestionAB.text = Label.text;
		SelectedquestionBB.text = Label.text;
		answerAB.text = KeyWordsDate.answers [questionIndex, KeyWordsDate.numberB].ToString();
		answerBB.text = KeyWordsDate.answers [questionIndex, KeyWordsDate.numberA].ToString();
	}

}
