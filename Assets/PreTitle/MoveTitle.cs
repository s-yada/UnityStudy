using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveTitle : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //タイトルへの遷移
        SceneManager.LoadScene("Title");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
