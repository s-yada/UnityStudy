using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FifthScoreDirector : MonoBehaviour {

    int fifthscore;

	// Use this for initialization
	void Start () {

        fifthscore = PlayerPrefs.GetInt("FIFTH SCORE");

        GetComponent<Text>().text =
            "5th : " + fifthscore.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
