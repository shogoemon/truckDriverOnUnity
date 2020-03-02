using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name=="Board"){
            Rigidbody rigidbodyComp=collision.gameObject.GetComponent<Rigidbody> ();
            if(this.transform.position.x>0){
                rigidbodyComp.AddForce(new Vector3(-1.0f,0.0f,0.0f),ForceMode.Impulse);
            }else{
                rigidbodyComp.AddForce(new Vector3(1.0f,0.0f,0.0f),ForceMode.Impulse);
            }
        }
    }

}
