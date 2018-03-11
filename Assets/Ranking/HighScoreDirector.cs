using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreDirector : MonoBehaviour {

    int highscore;

	// Use this for initialization
	void Start () {

        highscore = PlayerPrefs.GetInt("HIGH SCORE");

        GetComponent<Text>().text =
            "1st : " + highscore.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
