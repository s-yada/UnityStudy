using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForthScoreDirector : MonoBehaviour {

    int forthscore;

	// Use this for initialization
	void Start () {

        forthscore = PlayerPrefs.GetInt("FORTH SCORE");

        GetComponent<Text>().text =
            "4th : " + forthscore.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
