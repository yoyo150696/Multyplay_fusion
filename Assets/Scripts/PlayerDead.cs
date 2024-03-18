using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public class PlayerDead : NetworkBehaviour
{
    Health h;

    // Start is called before the first frame update
    void Start()
    {
        h = GetComponent<Health>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(h.NetworkedHealth < 1){
            Destroy(gameObject);
        }
        
    }
}
