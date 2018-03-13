using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmDirector : MonoBehaviour {

    public bool DontDestroyEnabled = true;

	// Use this for initialization
	void Start () {
		
	}
	
    //public void DestroyEnabled()
    //{
      //  DontDestroyEnabled = false;
    //}

	// Update is called once per frame
	void Update () {
        if (DontDestroyEnabled)
        {
            DontDestroyOnLoad(this);
        }
	}
}
