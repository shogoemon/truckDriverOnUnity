using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreScript : MonoBehaviour
{
    static Text scoreText;

    void Awake(){
        scoreText=this.GetComponent<Text>();
        setScore();
    }

    public static void setScore(){
            scoreText.text="Score "+ PlayingScript.PlayingScript.currentCoinScore;
    }
}
