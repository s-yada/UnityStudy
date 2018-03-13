using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreDirector : MonoBehaviour {

    int highScore; //ハイスコア用変数
    int secondScore; //2番目のスコア
    int thirdScore;　//3番目のスコア
    int forthScore;　//4番目のスコア
    int fifthScore;　//5番目のスコア

    string key1 = "HIGH SCORE"; //ハイスコアの保存先キー
    string key2 = "SECOND SCORE";
    string key3 = "THIRD SCORE";
    string key4 = "FORTH SCORE";
    string key5 = "FIFTH SCORE";

    int score;

    // Use this for initialization
    void Start () {

        highScore = PlayerPrefs.GetInt(key1, 0);
        //保存しておいたハイスコアをキーで呼び出し取得し保存されていなければ0になる,ValueはNG

        secondScore = PlayerPrefs.GetInt(key2, 0);
        thirdScore = PlayerPrefs.GetInt(key3, 0);
        forthScore = PlayerPrefs.GetInt(key4, 0);
        fifthScore = PlayerPrefs.GetInt(key5, 0);

        GetComponent<Text>().text = "BestScore : " + highScore.ToString();
        //ハイスコアを表示

        score = GameDirector.Pscore;
        //時間をスコアに変換
    }

    // Update is called once per frame
    void Update () {

        //ハイスコアより現在スコアが高い時
        if (score > highScore)
        {
            //ランキングの更新
            PlayerPrefs.SetInt(key1, score);
            PlayerPrefs.SetInt(key2, highScore);
            PlayerPrefs.SetInt(key3, secondScore);
            PlayerPrefs.SetInt(key4, thirdScore);
            PlayerPrefs.SetInt(key5, forthScore);

            //ハイスコア表示の更新
            GetComponent<Text>().text = "BestScore : "+score.ToString();
        }
        else if (score > secondScore && score<highScore)
        {
            PlayerPrefs.SetInt(key2, score);
            PlayerPrefs.SetInt(key3, secondScore);
            PlayerPrefs.SetInt(key4, thirdScore);
            PlayerPrefs.SetInt(key5, forthScore);
        }
        else if (score > thirdScore && score < secondScore)
        {
            PlayerPrefs.SetInt(key3, score);
            PlayerPrefs.SetInt(key4, thirdScore);
            PlayerPrefs.SetInt(key5, forthScore);
        }
        else if (score > forthScore && score < thirdScore)
        {
            PlayerPrefs.SetInt(key4, score);
            PlayerPrefs.SetInt(key5, forthScore);
        }
        else if (score > fifthScore && score < forthScore)
        {
            PlayerPrefs.SetInt(key5, score);
        }

    }
}
