using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    Vector3 localAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    localAngle = this.transform.localEulerAngles;
            if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log(localAngle);
                    if(!(localAngle.y>75&&localAngle.y<285)){
                    Debug.Log("ok");
                    }
            }
        
    }
}
