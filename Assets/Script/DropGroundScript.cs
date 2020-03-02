using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropGroundScript : MonoBehaviour
{
    GameObject genPrefab;
    GameObject genObj;
    int randomNum;

    void Awake(){
        for(int i=0;i<25;i=i+6){
        this.randomNum = UnityEngine.Random.Range(0, 19);      //擬似乱数を生成

                  switch(randomNum/10){
                  case 0:{      //コイン
                    genPrefab=(GameObject)Resources.Load ("Coin");
                    setObj(1.3f,i);
                    break;}
                  case 1:{      //岩
                    genPrefab=(GameObject)Resources.Load ("Block");
                    setObj(1.3f,i);
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
                                    this.transform.position.z-(float)25.0/2+i
                                    ),
                                Quaternion.identity) as GameObject;
                genObj.transform.SetParent(this.gameObject.transform);
    }


}
