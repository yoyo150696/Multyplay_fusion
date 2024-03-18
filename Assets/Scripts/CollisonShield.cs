using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public class CollisonShield : NetworkBehaviour
{

    void OnTriggerEnter(Collider other){

        if(other.name == "Ball(Clone)"){
            Debug.Log("here");
            Destroy(other);
            return;
        }
        if(transform.parent == null){
            transform.SetParent(other.transform);
        }
    }
}
