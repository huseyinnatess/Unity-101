using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TargetController : MonoBehaviour
{
    public Action onTargetDestroyed;

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        //Debug.Log(other.gameObject.name);
        if(other.gameObject.GetComponent<FloorController>() !=null){
            GameObject.Destroy(this.gameObject);
            onTargetDestroyed();
        }
        if(other.gameObject.GetComponent<BulletController>() !=null){
            GameObject.Destroy (this.gameObject);
            GameObject.Destroy(other.gameObject);
            onTargetDestroyed();
        }
    }
}
