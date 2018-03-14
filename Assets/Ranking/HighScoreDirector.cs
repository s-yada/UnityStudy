using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreDirector : MonoBehaviour {

    int highscore;

	// Use this for initialization
	void Start () {

        //ハイスコア（1位のスコア）の取得
        highscore = PlayerPrefs.GetInt("HIGH SCORE");

        //ハイスコアの表示
        GetComponent<Text>().text =
            "1st : " + highscore.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
