using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckButtonRanking : MonoBehaviour {

    GameObject Rankingbutton;

    // Use this for initialization
    void Start () {
        this.Rankingbutton = GameObject.Find("RankingButton");
    }
	
    public void Onclick2()
    {
        Rankingbutton.GetComponent<Image>().color = Color.blue;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
