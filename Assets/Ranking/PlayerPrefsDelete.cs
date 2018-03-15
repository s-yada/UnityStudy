using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsDelete : MonoBehaviour {

    //クリックした際に、データを消してタイトルへ飛ばす。
    public void OnClick()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Title");
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
