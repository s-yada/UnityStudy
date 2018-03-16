using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdown : MonoBehaviour {

    public Text Startcount;
    GameObject Audio;

	// Use this for initialization
	void Start () {

        Startcount.text = "TAP to START";

        //BGMを消す処理
        this.Audio = GameObject.Find("Audio Source");
        Destroy(Audio);
    }

    //カウントダウンを行ったあとゲームシーンへ遷移するメソッド
    IEnumerator Startcountdown()
    {
        Startcount.gameObject.SetActive(true);

        Startcount.text = "3";
        yield return new WaitForSeconds(1.0f);

        Startcount.text = "2";
        yield return new WaitForSeconds(1.0f);

        Startcount.text = "1";
        yield return new WaitForSeconds(1.0f);

        Startcount.text = "GO!";
        yield return new WaitForSeconds(1.0f);

        Startcount.text = "";
        Startcount.gameObject.SetActive(false);
        SceneManager.LoadScene("GameScene");
    }

	// Update is called once per frame
	void Update () {

        //マウスが押されたらカウントダウンのメソッドを呼び出す。
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Startcountdown());
        }
	}
}
