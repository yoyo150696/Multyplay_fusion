using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class CollisionHealth : NetworkBehaviour
{
    
    bool first = true;
        void OnTriggerEnter(Collider other){
            if (!HasStateAuthority)  return;
            
            if(first){
                Debug.Log(other.name);
                if(other.name == "Shield"){
                    Destroy(gameObject);
                    return;
                }
                Health d = other.GetComponent<Health>();
                d.DealDamageRpc(20);
                Debug.Log(name);
                Ball b  =  GetComponent<Ball>();
                b.PlayerHealth.addDamageRpc(10);
            }
        
        }
}
