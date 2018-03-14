using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFade : MonoBehaviour {

    GameObject fadeObj;　//フェード用の黒画像

    float startTime;

    public float fadeTime;　//フェードにかかる時間
    Color alpha;
    string fadeStart;


	// Use this for initialization
	void Start () {

        fadeObj = GameObject.Find("fade");
        startTime = Time.time;
        fadeStart = "FadeIn";　//画面遷移と同時にフェードイン開始
        fadeTime = 2.0f;
    }
	
    //スタートが押された時の処理
    public void StartPush()
    {
        fadeStart = "Fadeout";
        startTime = Time.time;
        Invoke("GameStart", 2.5f);　//2.5秒後に下記の"GameStart()"を行う
    }

    //ゲームシーンへの遷移
    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
    }

    // Update is called once per frame
    void Update () {

        //変数fadeStartの値でフェードイン・アウトの開始を管理
        switch (fadeStart)
        {
            //フェードインの処理　黒画面の透明度を時間で操作　alpha.aが0未満で透明
            case "FadeIn":
                alpha.a = 1.0f - (Time.time - startTime) / fadeTime;
                fadeObj.GetComponent<SpriteRenderer>().color= new Color(0, 0, 0, alpha.a);
                break;
            
            //フェードアウトの処理　黒画面の透明度を時間で操作　alpha.aが1以上で暗転
            case "Fadeout":
                alpha.a = (Time.time - startTime) / fadeTime;
                fadeObj.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, alpha.a);
                break;
        }


    }
}
