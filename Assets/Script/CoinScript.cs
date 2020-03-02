using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    void Awake(){
    this.transform.rotation = Quaternion.Euler(0.0f, 90.0f, 90.0f);
    }

    void OnTriggerEnter(Collider other){       //当たり判定
                PlayingScript.PlayingScript.currentCoinScore++;
                BoardScript.speedUp();
                scoreScript.setScore();
                                                //コイン取得時に音声を再生
                Destroy(this.gameObject);       //コインを消す
            }
}