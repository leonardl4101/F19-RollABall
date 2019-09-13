using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    private Rigidbody rb;

   void Start() 

    {
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVerticle = Input.GetAxis("Verticle");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVerticle);

        rb.AddForce(movement);
    }

      
}
