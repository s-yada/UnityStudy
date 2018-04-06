using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckButton : MonoBehaviour {

    GameObject Startbutton;

    
	// Use this for initialization
	void Start () {
        this.Startbutton = GameObject.Find("StartButton");
	}

    //TAP時にボタンの色を赤くするメソッド
    public void Onclick()
    {
        Startbutton.GetComponent<Image>().color = Color.red;
    }


    // Update is called once per frame
    void Update () {
		
	}
}
