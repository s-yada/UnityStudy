using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RescueController : MonoBehaviour {

    GameObject player;

    // Use this for initialization
    void Start()
    {
        this.player = GameObject.Find("player"); //オブジェクト"player"検索		
    }

    // Update is called once per frame
    void Update()
    {
        //フレームごとに矢を等速落下。
        transform.Translate(0, -0.1f, 0);

        //画面外に出たらオブジェクトを破棄
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //当たり判定
        Vector2 p1 = transform.position; //"arrow"の中心座標
        Vector2 p2 = this.player.transform.position; //"player"の中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f; //矢の半径
        float r2 = 1.0f; //プレイヤの半径

        if (d < r1 + r2)　//中心座標の距離が両半径の和未満の時
        {
            //監督スクリプトに当たり判定を伝える
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().IncreaseHp();

            //矢が当たった時のSEを再生する
            GameObject SEdir = GameObject.Find("Game_SEdirector");
            SEdir.GetComponent<GameSEdir>().RescueSe();

            Destroy(gameObject);　//オブジェクトを破棄
        }
    }
}