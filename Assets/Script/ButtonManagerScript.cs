using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManagerScript : MonoBehaviour
{
    string objName;

    void Start()
    {
        objName=this.gameObject.name;
    }

    void Update()
    {

    }

    public void OnTap(){
    switch(objName){
    case "StartButton":{
            PlayingScript.PlayingScript.currentCoinScore=0;
            SceneManager.LoadScene("PlayingScene");
            break;}
    case "RetryButton":{
            SceneManager.LoadScene("PlayingScene");
            PlayingScript.PlayingScript.currentCoinScore=0;
            break;}
    case "HomeButton":{SceneManager.LoadScene("StartScene");break;}
    }
    }
}
