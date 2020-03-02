using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision){
    if(collision.gameObject.name=="Board"){
    //ゲームオーバーの処理
    PlayingScript.PlayingScript.gameOverBool=true;
    Debug.Log("gameOver!");
    PlayingScript.PlayingScript.saveScore();
    CanvasScript.display(true);
    }
    }

    void Update()
    {
        
    }
}