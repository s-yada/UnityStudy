using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {

    GameObject hpGauge;
    GameObject timer;
    GameObject Audio;
    public static int Pscore;　//今回のスコア、resultでも使うのでstatic
    float score;
    float oldScore;

	// Use this for initialization
	void Start () {

        this.hpGauge = GameObject.Find("hp_gauge");
        this.Audio = GameObject.Find("Audio Source");
        this.timer = GameObject.Find("Timer");

        //スコアの初期化
        score = 0;

        //タイマーの初期化
        timer.GetComponent<Text>().text = "0 0 0 0";

        //タイトルBGMの破棄
        Destroy(Audio);
        	}
	
    //矢に当たった時のダメージ
    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    //赤い矢に当たった時のダメージ
    public void DecreaseHp2()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.2f;
    }

    //回復薬をとった時の回復
    public void IncreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount += 0.1f;
    }

	// Update is called once per frame
	void Update () {

        //終了判定
        if (this.hpGauge.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("Result");
            Pscore = ((int)score);
        }
        
        //スコアの加算
        score += Time.deltaTime;

        //スコア表示の更新
        if(score != oldScore)
        {
            timer.GetComponent<Text>().text =
                ((int)score).ToString();
        }

        oldScore = score;

    }
}
