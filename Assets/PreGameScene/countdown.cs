using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdown : MonoBehaviour {

    public Text Startcount;
    GameObject Audio;
    AudioSource Se_PO;
    AudioSource Se_Poon;

	// Use this for initialization
	void Start () {

        Startcount.text = "TAP to START";

        //BGMを消す処理
        this.Audio = GameObject.Find("Audio Source");
        Destroy(Audio);

        //スクリプト上の変数とオブジェクトに付加してあるSEを紐付け。
        AudioSource[] audioSources = GetComponents<AudioSource>();
        this.Se_PO = audioSources[0];
        this.Se_Poon = audioSources[1];
    }

    //カウントダウンを行ったあとゲームシーンへ遷移するメソッド
    IEnumerator Startcountdown()
    {
        Startcount.gameObject.SetActive(true);

        Startcount.text = "3";
        Se_PO.PlayOneShot(Se_PO.clip);
        yield return new WaitForSeconds(1.0f);

        Startcount.text = "2";
        Se_PO.PlayOneShot(Se_PO.clip);
        yield return new WaitForSeconds(1.0f);

        Startcount.text = "1";
        Se_PO.PlayOneShot(Se_PO.clip);
        yield return new WaitForSeconds(1.0f);

        Startcount.text = "GO!";
        Se_Poon.PlayOneShot(Se_Poon.clip);
        yield return new WaitForSeconds(3.0f);

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
