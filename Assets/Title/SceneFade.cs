using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFade : MonoBehaviour {

    GameObject fadeObj;

    float startTime;

    public float fadeTime;
    Color alpha;
    string fadeStart;


	// Use this for initialization
	void Start () {

        fadeObj = GameObject.Find("fade");
        startTime = Time.time;
        fadeStart = "FadeIn";
        fadeTime = 2.0f;
    }
	
    public void StartPush()
    {
        fadeStart = "Fadeout";
        startTime = Time.time;
        Invoke("GameStart", 2.5f);
    }

    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
    }

    // Update is called once per frame
    void Update () {

        switch (fadeStart)
        {
            case "FadeIn":
                alpha.a = 1.0f - (Time.time - startTime) / fadeTime;
                fadeObj.GetComponent<SpriteRenderer>().color= new Color(0, 0, 0, alpha.a);
                break;
            case "Fadeout":
                alpha.a = (Time.time - startTime) / fadeTime;
                fadeObj.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, alpha.a);
                break;
        }


    }
}
