﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDirector : MonoBehaviour {


    // Use this for initialization
    void Start () {
        
        //今回のスコアの表示
        GetComponent<Text>().text =
            "YourScore : "+GameDirector.Pscore.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
