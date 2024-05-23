using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public static Timer instance;

    public float timer = 0;
    public TextMeshProUGUI textoTimer;

    private int minutos = 0;
    private bool isPaused = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Hacer persistente el objeto
        }
        else
        {
            Destroy(gameObject); // Destruir el duplicado
        }
    }

    void Update()
    {
        if (!isPaused)
        {
            timer += Time.deltaTime;

            // Verificar si han pasado 60 segundos
            if (timer >= 60f)
            {
                minutos++; // Sumar un minuto
                timer -= 60f; // Restar 60 segundos
            }

            // Actualizar el texto del temporizador
            if (textoTimer != null)
            {
                textoTimer.text = minutos.ToString("00") + ":" + ((int)timer).ToString("00");
            }
        }
    }

    public void PauseTimer()
    {
        isPaused = true;
    }

    public void ResumeTimer()
    {
        isPaused = false;
    }

    public string GetFormattedTime()
    {
        return minutos.ToString("00") + ":" + ((int)timer).ToString("00");
    }
}
