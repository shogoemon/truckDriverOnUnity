using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
    GameObject boardObj;
    Vector3 boardPos;
    Vector3 currentPos;

    void Start()
    {
        boardObj=GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        currentPos=this.transform.position;
        boardPos=boardObj.transform.position;
        this.transform.position=new Vector3(boardPos.x,currentPos.y,boardPos.z-10.0f);
    }
}