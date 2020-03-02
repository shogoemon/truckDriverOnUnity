using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayingScript;

public class BoardScript : MonoBehaviour
{
   GameObject boardObj;
   Vector3 currentPos;
   Vector3 advancedPos;
   Vector3 jumpVec=new Vector3(0.0f,7.0f,0.0f);
   Vector2 firstClickPos;
   Vector2 firstTouchPos;
   Rigidbody rigidbodyComp;
   RaycastHit hit;
   static float boardSpeed;
   Vector3 localAngle;

    void Start()
    {
    rigidbodyComp = this.GetComponent<Rigidbody>();
    boardSpeed=1.0f;
    PlayingScript.PlayingScript.gameOverBool=false;
    }

    public static void speedUp(){
    if(PlayingScript.PlayingScript.currentCoinScore<31){
    boardSpeed=(13.0f+0.25f*PlayingScript.PlayingScript.currentCoinScore)/10.0f;
    //boardSpeed=(float)PlayingScript.PlayingScript.currentCoinScore*0.1f+1.0f;
    }
    }

    void Update()
    {
        if(!PlayingScript.PlayingScript.gameOverBool){
        //前進
        Vector3 forwardVec=this.gameObject.transform.forward;
        this.transform.position +=
        transform.TransformDirection(
            new Vector3(
                    forwardVec.x,
                    -forwardVec.y,
                    0.0f)
            )*0.3f*boardSpeed;

        localAngle = this.transform.localEulerAngles;
        //左右(key入力)

        if(Input.GetKey(KeyCode.LeftArrow)){
                //localAngle.x=-90.0f;
                localAngle.z-=1.0f*boardSpeed;
                this.transform.localEulerAngles=localAngle;
                //this.transform.Rotate (0.0f, 0.0f, -1.0f);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
                        //localAngle.x=-90.0f;
                        localAngle.z+=1.0f*boardSpeed;
                        this.transform.localEulerAngles=localAngle;
                }


        //ジャンプ(key入力)
        if(Input.GetKeyDown(KeyCode.Space)){
        Debug.Log(localAngle);
//            if(Physics.Raycast(this.transform.position,transform.TransformDirection(new Vector3(0.0f,0.0f,-0.5f)),out hit,0.1f)){
//                rigidbodyComp.AddForce(jumpVec,ForceMode.Impulse);
//            }
        }

        //左右(touch)
        if(Application.isEditor){
        //エディタ
            if(Input.GetMouseButtonDown(0)){
                firstClickPos=Input.mousePosition;
            }
            if(Input.GetMouseButton(0)){
                //クリックしたまま
                if((firstClickPos.x-Input.mousePosition.x)>0){
                        localAngle.x=-90.0f;
                        localAngle.z-=1.0f;
                        this.transform.localEulerAngles=localAngle;
                }
                if((firstClickPos.x-Input.mousePosition.x)<0){
                        localAngle.x=-90.0f;
                        localAngle.z+=1.0f;
                        this.transform.localEulerAngles=localAngle;
                                }
            }
        }else{
        //実機
        if(Input.touchCount==1){
            Touch touch=Input.GetTouch(0);
            if(touch.phase==TouchPhase.Began){
                //押した瞬間
                firstTouchPos=touch.position;
            }
            if(touch.phase==TouchPhase.Moved){
                //押したまま
                if((firstTouchPos.x-touch.position.x)>0){
                        //localAngle.x=-90.0f;
                        localAngle.z-=1.0f*boardSpeed;
                        this.transform.localEulerAngles=localAngle;
                }
                if((firstTouchPos.x-touch.position.x)<0){
                        //localAngle.x=-90.0f;
                        localAngle.z+=1.0f*boardSpeed;
                        this.transform.localEulerAngles=localAngle;
                                }
            }
            }//実機
        }
        }//gameOver
    }
}


//木、振り子、道を細めたカーブ道、トランポリン、坂道