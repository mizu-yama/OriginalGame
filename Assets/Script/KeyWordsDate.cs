using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class KeyWordsDate : MonoBehaviour {


	public static string[] keywords;
	public static string[] questions;
	public static bool[,] answers;//左側がquesutions、右側がkeywords
	public Text keywordA, keywordB;
	public Text SelectquestionA,SelectquestionB;
//	public Text cardA1, cardA2, cardA3;
//	public Text cardB1, cardB2, cardB3;


	private TextAsset csvFile; // CSVファイル

	// Use this for initialization
	void Start () {

		//配列の箱の数の指定
		keywords = new string[20];
		questions = new string[50];
		answers = new bool[50, 20];

		csvFile = Resources.Load("CSV/" + "SeaKeywords") as TextAsset; /* Resouces/CSV下のCSV読み込み */
		StringReader reader = new StringReader(csvFile.text);

		//行の指定
		int height = 0;

		while (reader.Peek () > -1) {
			string line = reader.ReadLine ();
			string[] array = line.Split (',');

			//配列arrayの値の入っている箱の数
			int number = array.Length;
//			Debug.Log (number);
//			Debug.Log (line);
//			Debug.Log (height);

			if (height == 0) {
				//配列keywordsに値の代入
				for (int i = 1; i < number; i++) {
					keywords [i - 1] = array [i];
				}
			} else {
				//配列questionsに値の代入
				questions [height-1] = array [0];
//				Debug.Log (questions [height-1]);
				//配列answersに値の代入
				for (int i = 1; i < number; i++) {
					if (array [i] == "〇") {
						answers [height - 1, i - 1] = true;
					} else {
						answers [height - 1, i - 1] = false;
					}
				}
			}
			//一段行を下げる
			height++;
		}
//		Debug.Log (keywords [0]);
//		Debug.Log (keywords [19]);
//		Debug.Log (questions[0]);
//		Debug.Log (questions[20]);
//		Debug.Log (answers[0,0]);

		decide ();

	}

	void decide(){
		int numberA = Random.Range (0, keywords.Length);
		int numberB = Random.Range (0, keywords.Length);

		keywordA.text = keywords [numberA].ToString();
		keywordB.text = keywords [numberB].ToString();


	}


	
	// Update is calle		d once per frame
	void Update () {




	}
}
