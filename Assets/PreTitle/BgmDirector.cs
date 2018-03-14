using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmDirector : MonoBehaviour {

    public bool DontDestroyEnabled = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //BGMを流しっぱなしにする処理
        if (DontDestroyEnabled)
        {
            DontDestroyOnLoad(this);
        }
	}
}
