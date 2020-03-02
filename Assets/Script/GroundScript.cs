using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
   GameObject genPrefab;
   GameObject genObj;
    int randomNum;
    int randomRange=39;

    void Awake(){
    int i=0;
    if(PlayingScript.PlayingScript.bridgeTrapBool){
    i=10;
    PlayingScript.PlayingScript.bridgeTrapBool=false;
    }
    for(;i<25;i=i+5){
    if(PlayingScript.PlayingScript.currentCoinScore>5){
        randomRange=29;
    }
    this.randomNum = UnityEngine.Random.Range(0, randomRange);      //擬似乱数を生成

              switch(randomNum/10){
              case 0:{      //コイン
                genPrefab=(GameObject)Resources.Load ("Coin");
                setObj(1.45f,i);
                break;}
              case 1:{      //岩
                genPrefab=(GameObject)Resources.Load ("Block");
                setObj(1.3f,i);
                break;}
              case 2:{      //爆弾
                genPrefab=(GameObject)Resources.Load ("Bomber");
                setObj(2.0f,i);
                genObj.transform.Rotate (-90.0f, 0.0f, 0.0f);
                break;}
              case 3:{      //無し
                genPrefab=(GameObject)Resources.Load ("Coin");
                setObj(1.45f,i);
                break;}
              }

        }
    }

    void setObj(float objPos_y,int i){
              genObj=
                Instantiate(
                                genPrefab,
                                new Vector3(
                                    ((randomNum) % 5 - 2)*3,
                                    objPos_y,
                                    this.transform.position.z-(float)25.0/2+i+1.0f
                                    ),
                                Quaternion.identity) as GameObject;
                genObj.transform.SetParent(this.gameObject.transform);
    }

}