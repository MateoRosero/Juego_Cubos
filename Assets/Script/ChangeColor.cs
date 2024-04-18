using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Rigidbody rb; 

    void Start()
    {
        GetComponent<Renderer>().material.color = Color.white;

        rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.useGravity = false;
        }
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.R))
        {
           
            GetComponent<Renderer>().material.color = Color.red;
        }
     
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (rb != null)
            {
                rb.useGravity = true;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.name == "Rampa")
        {
           
            Destroy(collision.gameObject);

            Destroy(gameObject);
        }
    }
}

