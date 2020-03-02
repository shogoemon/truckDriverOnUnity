using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBlockScript : MonoBehaviour
{
    Vector3 TriggerPos;
    int randomNum;
    GameObject dropBlockPrefab;
    GameObject dropBlockObj;
    Vector3 dropPos;
    bool dropped=false;


    void Start()
    {
        TriggerPos=this.transform.position;
        this.randomNum = UnityEngine.Random.Range(0, 6);
        dropPos=new Vector3((randomNum-2)*3,10.0f,this.transform.position.z+31.0f);
    }

    void OnTriggerEnter(Collider other){       //当たり判定
            Debug.Log("dropBlock trigger hit");
            if(!dropped){
                dropBlockPrefab=(GameObject)Resources.Load ("DropBlock");
                dropBlockObj=Instantiate(dropBlockPrefab,dropPos,Quaternion.identity) as GameObject;     //ブロック落下
                dropBlockObj.transform.SetParent(this.gameObject.transform);
                Rigidbody rigidbodyComp=dropBlockObj.GetComponent<Rigidbody> ();
                rigidbodyComp.AddForce(new Vector3(0.0f,-2.0f,0.0f),ForceMode.Impulse);
            }
    }
}
