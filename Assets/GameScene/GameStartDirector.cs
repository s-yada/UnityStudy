using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartDirector : MonoBehaviour {

    public Text CountDownText;
    //float realtime;

	// Use this for initialization
	void Start () {

        Time.timeScale = 0f;
        Countdown();

    }

    public void Countdown()
    {
        CountDownText.gameObject.SetActive(true);

        if (Time.realtimeSinceStartup == 1.0f)
        {
            CountDownText.text = "3";
        }
        else if (Time.realtimeSinceStartup == 2.0f)
        {
            CountDownText.text = "2";
        }
        else if (Time.realtimeSinceStartup == 3.0f)
        {
            CountDownText.text = "1";
        }
        else if (Time.realtimeSinceStartup == 4.0f)
        {
            CountDownText.text = "GO!";
        }
        else if(Time.realtimeSinceStartup >= 5.0f)
        {
            CountDownText.text = "";
            CountDownText.gameObject.SetActive(false);
            Time.timeScale = 1.0f;
            Destroy(gameObject);
        }
    }

	// Update is called once per frame
	void Update () {

        //realtime = Time.realtimeSinceStartup;

	}
}
