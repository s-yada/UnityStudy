using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {

    GameObject hpGauge;
    GameObject timer;
    GameObject Generator;
    public static int Pscore;　//今回のスコア、resultでも使うのでstatic
    float score;
    float oldScore;

	// Use this for initialization
	void Start () {

        this.hpGauge = GameObject.Find("hp_gauge");
        this.timer = GameObject.Find("Timer");
        this.Generator = GameObject.Find("ArrowGenerator");

        //スコアの初期化
        score = 0;

        //タイマーの初期化
        timer.GetComponent<Text>().text = "0 0 0 0";

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

        //レベルデザイン　秒数経過のたびに矢などの落下頻度が変化
        if (0 <= score && score < 10)
        {
            this.Generator.GetComponent<ArrowGenerator>().SetParameter(1.5f, 10.5f, 1.0f);
        }
        else if(10 <= score && score < 20)
        {
            this.Generator.GetComponent<ArrowGenerator>().SetParameter(1.25f, 5.0f, 2.0f);
        }
        else if (20 <= score && score < 30)
        {
            this.Generator.GetComponent<ArrowGenerator>().SetParameter(1.1f, 3.0f, 5.0f);
        }
        else if (30 <= score && score < 40)
        {
            this.Generator.GetComponent<ArrowGenerator>().SetParameter(1.1f, 2.0f, 8.0f);
        }
        else if (40 <= score && score < 50)
        {
            this.Generator.GetComponent<ArrowGenerator>().SetParameter(1.1f, 1.5f, 9.0f);
        }
        else if (50 <= score && score < 60)
        {
            this.Generator.GetComponent<ArrowGenerator>().SetParameter(1.1f, 1.1f, 9.0f);
        }
        else if (60 <= score && score < 70)
        {
            this.Generator.GetComponent<ArrowGenerator>().SetParameter(0.9f, 1.0f, 9.0f);
        }
        else if (70 <= score && score < 80)
        {
            this.Generator.GetComponent<ArrowGenerator>().SetParameter(0.75f, 0.8f, 9.0f);
        }
        else
        {
            this.Generator.GetComponent<ArrowGenerator>().SetParameter(0.75f, 0.75f, 9.0f);
        }

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
