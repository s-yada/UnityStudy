﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndDirector : MonoBehaviour {


	// Use this for initialization
	void Start () {

            }
	
	// Update is called once per frame
	void Update () {

        

        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Title");
            GameDirector.Pscore = 0;
        }

	}
}
