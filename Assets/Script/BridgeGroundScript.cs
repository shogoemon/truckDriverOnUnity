using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeGroundScript : MonoBehaviour
{
    GameObject bridgePrefab;
    GameObject bridgeObj;
    Vector3 bridgePos;
    int randomNum;

    void Start()
    {
     this.randomNum = UnityEngine.Random.Range(0, 6);
     bridgePos=new Vector3((randomNum-2)*3,0.07f,this.transform.position.z+5.0f);
     bridgePrefab=(GameObject)Resources.Load ("Bridge");
     bridgeObj=Instantiate(bridgePrefab,bridgePos,Quaternion.identity) as GameObject;     //ブロック落下
     bridgeObj.transform.SetParent(this.gameObject.transform);
    }

    void Update()
    {
    }
}