using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FifthScoreDirector : MonoBehaviour {

    int fifthscore;

	// Use this for initialization
	void Start () {
        
        //格納されている5位のスコアの取得
        fifthscore = PlayerPrefs.GetInt("FIFTH SCORE");

        //5位のスコアの表示
        GetComponent<Text>().text =
            "5th : " + fifthscore.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
