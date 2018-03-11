using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdScoreDirector : MonoBehaviour {

    int thirdscore;

	// Use this for initialization
	void Start () {

        thirdscore = PlayerPrefs.GetInt("THIRD SCORE");

        GetComponent<Text>().text =
            "3rd : " + thirdscore.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
