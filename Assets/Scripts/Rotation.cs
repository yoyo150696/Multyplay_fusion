using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public class Rotation : NetworkBehaviour
{
    public GameObject healthbar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!HasStateAuthority)  return;

         if (Input.GetKey(KeyCode.A)){
           transform.Rotate(Vector3.up * 150 * Time.deltaTime);
           healthbar.transform.Rotate(Vector3.down* 150 * Time.deltaTime);
       } else if (Input.GetKey(KeyCode.D)){
           transform.Rotate(Vector3.down* 150 * Time.deltaTime);
           healthbar.transform.Rotate(Vector3.up * 150 * Time.deltaTime);
       }     
    }
}
