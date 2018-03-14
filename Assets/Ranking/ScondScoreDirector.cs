using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScondScoreDirector : MonoBehaviour {

    int secondscore;

	// Use this for initialization
	void Start () {

        //2位のスコアの取得
        secondscore = PlayerPrefs.GetInt("SECOND SCORE");

        //2位のスコアの表示
        GetComponent<Text>().text =
            "2nd : " + secondscore.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
