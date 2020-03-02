using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpGroundScript : MonoBehaviour
{
   GameObject boardObj;
   GameObject newGround;
   GameObject genPrefab;
   GameObject genObj;
    Vector3 boardPos;
    Vector3 currentPos;
    Vector3 nextPos;
    int randomNum;

    void Start()
    {
       boardObj=GameObject.FindGameObjectWithTag("Player");         //ボードのオブジェクトを取得
       currentPos=this.transform.position;     //地面の現在地を取得
    }

    void Update()
    {
            boardPos=boardObj.transform.position;   //ボードの位置を取得
            if(currentPos.z-boardPos.z<-20.0f){     //地面の位置とボールの位置が一定以上離れた場合
            nextPos=new Vector3(currentPos.x,currentPos.y,currentPos.z + 100.0f);        //次の地面が生成される位置
            this.randomNum = UnityEngine.Random.Range(0, 3);
              switch(randomNum){
              case 0:{      //ジャンプ台
                newGround=(GameObject)Resources.Load ("JumpGround");
                break;}
              case 1:{      //通常の道
                newGround=(GameObject)Resources.Load ("NormalGround");
                break;}
              case 2:{      //橋
                newGround=(GameObject)Resources.Load ("BridgeGround");
                break;}
              }
            Instantiate(newGround,nextPos,Quaternion.identity);     //次の地面を配置
            Destroy(this.gameObject);       //現在の地面のオブジェクトを消す
            }
    }
}
