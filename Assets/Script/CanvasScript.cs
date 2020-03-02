using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
     public static GameObject gameOverPanelObj;
        void Awake(){
        gameOverPanelObj=GameObject.FindWithTag("Finish");
        gameOverPanelObj.SetActive (false);
        }

        public static void display(bool dispBool){
        gameOverPanelObj.SetActive (dispBool);
        }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
