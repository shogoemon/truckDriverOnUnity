using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpStandScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name=="Board"){
            Rigidbody rigidbodyComp=collision.gameObject.GetComponent<Rigidbody> ();
            rigidbodyComp.AddForce(new Vector3(0.0f,1.0f,1.0f),ForceMode.Force);
        }
    }
}
