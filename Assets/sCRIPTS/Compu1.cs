using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compu1 : MonoBehaviour
{
    private bool cercaComputadora = false;
    public KeyCode teclaInteraccion = KeyCode.E;

    private void Update()
    {
        // Detectar si el jugador está cerca de la computadora 
        if (cercaComputadora && Input.GetKeyDown(teclaInteraccion))
        {
            AccionInteraccion();
        }
    }

    private void AccionInteraccion()
    {
        
        Debug.Log("Interactuando con la computadora...");
    }

    private void OnTriggerEnter(Collider other)
    {
        // Detectar cuando el jugador se acerca a la zona de la computadora
        if (other.CompareTag("Player"))
        {
            cercaComputadora = true;
            Debug.Log("Jugador cerca de la computadora.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Detectar cuando el jugador se aleja de la zona de la computadora
        if (other.CompareTag("Player"))
        {
            cercaComputadora = false;
            Debug.Log("Jugador se alejó de la computadora.");
        }
    }
}
