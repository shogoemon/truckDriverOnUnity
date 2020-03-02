using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScoreScript : MonoBehaviour
{
    Text scoreText;

    void Awake(){
    scoreText=this.GetComponent<Text>();
    PlayingScript.PlayingScript.loadScore();
    }

    void Start()
    {
        scoreText.text="HighScore:"+PlayingScript.PlayingScript.highScore;
    }

    void Update()
    {
        
    }
}