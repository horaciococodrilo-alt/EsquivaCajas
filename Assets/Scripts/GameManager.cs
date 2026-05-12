using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Necesario para usar TextMeshPro (la UI moderna de Unity)

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Arrastrar el texto de la UI acá
    private float timer = 0f;
    private bool isGameOver = false;

    void Update()
    {
        // Si el juego sigue corriendo, sumamos tiempo
        if (!isGameOver)
        {
            timer += Time.deltaTime;
            // Formateamos el float a un string con 2 decimales
            timerText.text = "Tiempo: " + timer.ToString("F2");
        }
    }

    // El jugador va a llamar a esta función cuando choque
    public void GameOver()
    {
        isGameOver = true;
    }
}