using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class CollisionHealth : NetworkBehaviour
{
    
    bool first = true;
        void OnTriggerEnter(Collider other){
            
            if(first){
                Debug.Log(other.name);
                if(other.name == "Shield"||other.name == "Plane"){
                    Destroy(gameObject);
                    return;
                }
                Debug.Log("Yees");    
                Health d = other.GetComponent<Health>();
                d.DealDamageRpc(2);
                Debug.Log(name);
                Ball b  =  GetComponent<Ball>();
                b.PlayerHealth.addDamageRpc(2);
            }
        
        }
}
