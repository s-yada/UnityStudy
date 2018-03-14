using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForthScoreDirector : MonoBehaviour {

    int forthscore;

	// Use this for initialization
	void Start () {

        //4位のスコアの取得
        forthscore = PlayerPrefs.GetInt("FORTH SCORE");

        //4位のスコアの表示
        GetComponent<Text>().text =
            "4th : " + forthscore.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
