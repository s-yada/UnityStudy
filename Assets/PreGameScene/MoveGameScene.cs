using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveGameScene : MonoBehaviour {

    //ゲームシーンへ遷移するメソッド
    public void MoveScene()
    {
        SceneManager.LoadScene("GameScene");
    }

	// Use this for initialization
	void Start () {

        //1.25秒後にゲームシーンへ移動
        Invoke("MoveScene", 1.25f);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
