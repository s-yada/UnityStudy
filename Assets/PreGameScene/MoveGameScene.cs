using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveGameScene : MonoBehaviour {

    GameObject Fade;

    //ゲームシーンへ遷移するメソッド
    public void MoveScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void FadeDelete()
    {
        this.Fade = GameObject.Find("fade");
        Destroy(Fade);
    }

	// Use this for initialization
	void Start () {

        //1.25秒後に背景を表示
        Invoke("FadeDelete", 1.25f);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
