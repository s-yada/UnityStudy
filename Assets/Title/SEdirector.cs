using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEdirector : MonoBehaviour {

    AudioSource audioSource;
    AudioSource audioSource2;

	// Use this for initialization
	void Start () {

        AudioSource[] audioSources = GetComponents<AudioSource>();
        this.audioSource = audioSources[0];
        this.audioSource2 = audioSources[1];
    }
	
    //Startが押されたときにSEを鳴らす
    public void touchSE_Start()
    {
        audioSource.PlayOneShot(audioSource.clip);
    }

    //Rankingが押されたときにならすSE
    public void touchSE_Ranking()
    {
        DontDestroyOnLoad(this);
        audioSource2.PlayOneShot(audioSource2.clip);
    }
    
    // Update is called once per frame
    void Update () {
		
	}
}
