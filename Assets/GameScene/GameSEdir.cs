using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSEdir : MonoBehaviour {

    AudioSource arrowSE;
    AudioSource RarrowSE;
    AudioSource rescueSE;

    // Use this for initialization
    void Start () {

        AudioSource[] audioSources = GetComponents<AudioSource>();
        this.arrowSE = audioSources[0];
        this.RarrowSE = audioSources[1];
        this.rescueSE = audioSources[2];
    }
	
    public void ArrowSe()
    {
        arrowSE.PlayOneShot(arrowSE.clip);
    }

    public void RArrowSe()
    {
        RarrowSE.PlayOneShot(RarrowSE.clip);
    }

    public void RescueSe()
    {
        rescueSE.PlayOneShot(rescueSE.clip);
    }



    // Update is called once per frame
    void Update () {
		
	}
}
