using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 5;
    bool LeftPush = false;
    bool RightPush = false;
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

        if (LeftPush && !RightPush)
        {
            LeftMove();
        }

        if(!LeftPush && RightPush)
        {
            RightMove();
        }

        if (this.transform.position.x < -9.9f || this.transform.position.x > 9.9f)
        {
            outtime += Time.deltaTime;
        }

        GameObject Director = GameObject.Find("GameDirector");

        if (outtime > 0.7f)
        {
            Director.GetComponent<GameDirector>().DecreaseHp();
            outtime = 0;
        }

        Debug.Log(outtime);

        }
       
}
