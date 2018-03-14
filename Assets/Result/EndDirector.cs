using System.Collections;
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

        
        //マウスのボタンが押されたときにタイトル準備画面へ遷移、スコアの値も初期化する。
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("PreTitle");
            GameDirector.Pscore = 0;
        }

	}
}
