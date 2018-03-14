using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowGenerator : MonoBehaviour {

    public GameObject arrowPrefab;
    public GameObject RarrowPrefab;
    public GameObject RescuePrefab;
    GameObject hpGauge;

    //無：普通の矢　R：赤い矢　Res：回復アイテム
    float span = 0.5f;
    float Rspan = 2.0f;
    float ReSpan = 1.0f;

    float delta = 0;
    float Rdelta = 0;
    float ResDelta = 0;

	// Use this for initialization
	void Start () {

        this.hpGauge = GameObject.Find("hp_gauge");

    }
	
	// Update is called once per frame
	void Update () {

        //矢の生成
        this.delta += Time.deltaTime;
        if (this.delta > span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }

        //赤い矢の生成
        this.Rdelta += Time.deltaTime;
        if (this.Rdelta > Rspan)
        {
            this.Rdelta = 0;
            GameObject Rgo = Instantiate(RarrowPrefab) as GameObject;
            int px = Random.Range(-6, 7);
            Rgo.transform.position = new Vector3(px, 7, 0);
        }

        //回復アイテムの生成
        this.ResDelta += Time.deltaTime;
        if (this.ResDelta > ReSpan && this.hpGauge.GetComponent<Image>().fillAmount < 1.0f)
        {
            this.ResDelta = 0;
            GameObject Resgo = Instantiate(RescuePrefab) as GameObject;
            int px = Random.Range(-6, 7);
            Resgo.transform.position = new Vector3(px, 7, 0);
        }
        else if(this.ResDelta > ReSpan)
        {
            this.ResDelta = 0;
        }

    }
}
