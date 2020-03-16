using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneCamera : MonoBehaviour
{

    //最初に作った画面のwidth
    float defaultWidth = 2436.0f;

    //最初に作った画面のheight
    float defaultHeight = 1135.0f;

    void Start()
    {
               //camera.mainを変数に格納
               Camera mainCamera = Camera.main;

               //最初に作った画面のアスペクト比
               float defaultAspect = defaultWidth / defaultHeight;

               //実際の画面のアスペクト比
               float actualAspect = (float)Screen.width / (float)Screen.height;

               //実機とunity画面の比率
               float ratio = actualAspect / defaultAspect;
               Debug.Log(ratio);

               //サイズ調整
               mainCamera.orthographicSize /= ratio;
    }
}
