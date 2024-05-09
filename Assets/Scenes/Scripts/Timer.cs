using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timer = 0;
    public TextMeshProUGUI textoTimer;

    private int minutos = 0;

    void Update()
    {
        timer += Time.deltaTime;

        // Verificar si han pasado 60 segundos
        if (timer >= 60f)
        {
            minutos++; // Sumar un minuto
            timer -= 60f; // Restar 60 segundos
        }

        // Actualizar el texto del temporizador
        textoTimer.text = minutos.ToString("00") + ":" + timer.ToString("00");
    }
}
