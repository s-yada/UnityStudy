using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {

    GameObject hpGauge;
    GameObject timer;
    public static int Pscore;
    float score;
    float oldScore;

	// Use this for initialization
	void Start () {

        this.hpGauge = GameObject.Find("hp_gauge");

        this.timer = GameObject.Find("Timer");
        score = 0;

        //minuite = 0;
        //seconds = 0f;
        //oldSeconds = 0f;
        //Pminuite = 0;

        timer.GetComponent<Text>().text = "0 0 0 0";
        	}
	
    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

	// Update is called once per frame
	void Update () {

        if (this.hpGauge.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("Result");
            Pscore = ((int)score);
        }

        score += Time.deltaTime;

        if(score != oldScore)
        {
            timer.GetComponent<Text>().text =
                ((int)score).ToString();
        }

        oldScore = score;

    }
}
