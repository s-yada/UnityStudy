using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdScoreDirector : MonoBehaviour {

    int thirdscore;

	// Use this for initialization
	void Start () {

        //3位のスコアの取得
        thirdscore = PlayerPrefs.GetInt("THIRD SCORE");

        //3位のスコアの表示
        GetComponent<Text>().text =
            "3rd : " + thirdscore.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
