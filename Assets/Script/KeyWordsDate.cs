using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class KeyWordsDate : MonoBehaviour {

	public static string[] keywords;
	public static string[] questions;
	public static string[,] answers;//左側がquesutions、右側がkeywords
	public static int numberA;
	public static int numberB;

	private TextAsset csvFile; // CSVファイル

	// Use this for initialization
	void Awake () {

		//配列の箱の数の指定
		keywords = new string[20];
		questions = new string[19];
		answers = new string[19, 20];

		csvFile = Resources.Load("CSV/" + "SeaKeywords1") as TextAsset; /* Resouces/CSV下のCSV読み込み */
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
						answers [height - 1, i - 1] = "YES";
					} else {
						answers [height - 1, i - 1] = "NO";
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
		KeyWordsDate.numberA = Random.Range (0, KeyWordsDate.keywords.Length);
		KeyWordsDate.numberB = Random.Range (0, KeyWordsDate.keywords.Length);

	}

	// Update is calle		d once per frame
	void Update () {

	}
}
