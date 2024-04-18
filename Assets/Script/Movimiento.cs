using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject explosionEffect;

    void Start()
    {
        // Mensaje de inicializaci�n en la consola de Unity
        Debug.Log("Movimiento inicializado!");
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Esfera2")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}

