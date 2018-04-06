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
        this.arrowSE = audioSources[0];　//矢に当たった時のSE
        this.RarrowSE = audioSources[1];　//赤い矢に当たった時のSE
        this.rescueSE = audioSources[2];　//回復アイテムをとった時のSE
    }
	
    //矢に当たったSEを流すメソッド
    public void ArrowSe()
    {
        arrowSE.PlayOneShot(arrowSE.clip);
    }

    //赤い矢に当たったSEを流すメソッド
    public void RArrowSe()
    {
        RarrowSE.PlayOneShot(RarrowSE.clip);
    }

    //回復アイテムをとったSEを流すメソッド
    public void RescueSe()
    {
        rescueSE.PlayOneShot(rescueSE.clip);
    }



    // Update is called once per frame
    void Update () {
		
	}
}
