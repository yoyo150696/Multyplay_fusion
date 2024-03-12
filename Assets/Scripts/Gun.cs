using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public class Gun : NetworkBehaviour
{
    
    public GameObject Ball;
    public GameObject BallSpawnPoint;
    // Start is called before the first frame update
    void Update()
    {
        if (!HasStateAuthority)  return;

        if(Input.GetKeyDown(KeyCode.S)){
            GameObject newObjet = Instantiate(Ball,BallSpawnPoint.transform.position,BallSpawnPoint.transform.rotation);
            Ball b = newObjet.GetComponent<Ball>();
            Health h = GetComponentInParent<Health>();
            b.ChangePlayer(h);


        }
    }
}
