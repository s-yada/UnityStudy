using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackTop : MonoBehaviour {

    public void ToTitle()
    {
        //タイトルへ戻る
        SceneManager.LoadScene("Title");
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
