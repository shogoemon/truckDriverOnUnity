using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryScript : MonoBehaviour
{
    GameObject parantGround;
    string parentName;
   GameObject newGround;
    Vector3 currentPos;
    Vector3 nextPos;
    int randomNum;

    void Start()
    {
        parantGround=transform.root.gameObject;
        parentName=parantGround.name;
    }

    void OnTriggerEnter(Collider other){
    if(other.name=="Board"){
    //Debug.Log(parantGround.name);

    if(parentName.Contains("StartGround")){
        Destroy(parantGround);
     }
     if(parentName.Contains("NormalGround")){
        Destroy(parantGround);
        currentPos=parantGround.transform.position;
        nextPos=new Vector3(currentPos.x,currentPos.y,currentPos.z + 100.0f);        //次の地面が生成される位置
        this.randomNum = UnityEngine.Random.Range(0, 3);
        switch(randomNum){
              case 0:{      //落石
                if(!PlayingScript.PlayingScript.dropTrapBool){
                    newGround=(GameObject)Resources.Load ("DropGround");
                    PlayingScript.PlayingScript.dropTrapBool=true;
                    PlayingScript.PlayingScript.bridgeTrapBool=false;
                }else{
                    newGround=(GameObject)Resources.Load ("NormalGround");
                    PlayingScript.PlayingScript.dropTrapBool=false;
                    PlayingScript.PlayingScript.bridgeTrapBool=false;
                }
                break;}
              case 1:{      //通常の道
                newGround=(GameObject)Resources.Load ("NormalGround");
                PlayingScript.PlayingScript.dropTrapBool=false;
                break;}
              case 2:{      //橋
                newGround=(GameObject)Resources.Load ("BridgeGround");
                PlayingScript.PlayingScript.dropTrapBool=true;
                PlayingScript.PlayingScript.bridgeTrapBool=true;
                break;}
         }
         Instantiate(newGround,nextPos,Quaternion.identity);     //次の地面を配置
     }
     if(parentName.Contains("BridgeGround")){
        Destroy(parantGround);
        currentPos=parantGround.transform.position;
        nextPos=new Vector3(currentPos.x,currentPos.y,currentPos.z + 100.0f);        //次の地面が生成される位置
        newGround=(GameObject)Resources.Load ("NormalGround");
        Instantiate(newGround,nextPos,Quaternion.identity);     //次の地面を配置
     }
     if(parentName.Contains("DropGround")){
        Destroy(parantGround);
        currentPos=parantGround.transform.position;
        nextPos=new Vector3(currentPos.x,currentPos.y,currentPos.z + 100.0f);        //次の地面が生成される位置
        newGround=(GameObject)Resources.Load ("NormalGround");
        Instantiate(newGround,nextPos,Quaternion.identity);     //次の地面を配置
     }
        }// if name==board
    }//trigger
}