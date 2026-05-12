using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetector : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Caja"))
        {
           // Buscamos el GameManager en la escena y le decimos que frene el tiempo
           FindObjectOfType<GameManager>().GameOver();
           
           Destroy(gameObject); 
        }
    }
}