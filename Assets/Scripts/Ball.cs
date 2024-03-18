using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public class Ball : NetworkBehaviour
{
    public float Force = 15f;
    public Health PlayerHealth;
    float timeLeft = 2.0f;
    Rigidbody rb;
    // Start is called before the first frame update
    public void ChangePlayer(Health h){
        PlayerHealth = h;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward *Force,ForceMode.Impulse);
    }
    void Update(){
        if (!HasStateAuthority)  return;
        timeLeft -= Time.deltaTime;
        if(timeLeft < 0)
            Destroy(gameObject);
    }
}
