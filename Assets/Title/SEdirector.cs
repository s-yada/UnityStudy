using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEdirector : MonoBehaviour {

    public AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = gameObject.GetComponent<AudioSource>();
	}
	
    public void touchSE_Start()
    {
        audioSource.Play();
    }

	// Update is called once per frame
	void Update () {
		
	}
}
