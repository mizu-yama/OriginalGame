using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Actioncards : MonoBehaviour {

	public string word;//表示される文字列
	public int questionIndex;//questionsのIndex（表の何番目か）
	public Text Label;//UIのラベル
	public Text SelectquestionA,SelectquestionB;

	public Text SelectedquestionA;
	public Text SelectedquestionB;
	public Text answerA, answerB;

	// Use this for initialization
	void Start () {
		questionIndex = Random.Range (0, KeyWordsDate.questions.Length);
		word = KeyWordsDate.questions [questionIndex];
		//questionIndexを選択したら、CSVのデータからwordの中身につっこむ
		Label.text = word;
	}
		
	public void SelectA(){
		SelectquestionA.text = Label.text;
		SelectedquestionA.text = Label.text;
		answerA.text = KeyWordsDate.answers [questionIndex, KeyWordsDate.numberB].ToString();
			
	}		

	public void SelectB(){
		SelectquestionB.text = Label.text;
		SelectedquestionB.text = Label.text;
		answerB.text = KeyWordsDate.answers [questionIndex, KeyWordsDate.numberA].ToString ();
	}

}
