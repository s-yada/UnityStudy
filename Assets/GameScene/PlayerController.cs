using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //移動速度
    public float speed = 5;
    
    //ボタンの判定
    bool LeftPush = false;
    bool RightPush = false;
    
    //画面外滞在量
    float outtime;
    

    // Use this for initialization
    void Start () {
        
    }

    //左の矢印が押された
    public void LeftButtonDown()
    {
        LeftPush = true;
    }

    //左の矢印が離された
    public void LeftButtonUp()
    {
        LeftPush = false;
    }

    //左に移動
    public void LeftMove()
    {
        Vector2 direction = new Vector2(-1.0f, 0).normalized;
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }


    //右の矢印が押された
    public void RightButtonDown()
    {
        RightPush = true;
    }

    //右の矢印が離された
    public void RightButtonUp()
    {
        RightPush = false;
    }

    //右に移動
    public void RightMove()
    {
        Vector2 direction = new Vector2(1.0f, 0).normalized;
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }




    // Update is called once per frame
    void Update () {

        //左に移動させる判定
        if (LeftPush && !RightPush)
        {
            LeftMove();
        }

        //右に移動させる判定
        if (!LeftPush && RightPush)
        {
            RightMove();
        }

        //画面外に出ている間 outtime を加算
        if (this.transform.position.x < -9.9f || this.transform.position.x > 9.9f)
        {
            outtime += Time.deltaTime;
        }

        GameObject Director = GameObject.Find("GameDirector");

        //outtimeが一定量貯まるとダメージ
        if (outtime > 0.7f)
        {
            Director.GetComponent<GameDirector>().DecreaseHp();
            outtime = 0;
        }

        }
       
}
