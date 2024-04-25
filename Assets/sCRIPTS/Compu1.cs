using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compu1 : MonoBehaviour
{
    private bool cercaComputadora = false;
    public KeyCode teclaInteraccion = KeyCode.E;

    private void Update()
    {
        // Detectar si el jugador está cerca de la computadora y presiona la tecla de interacción
        if (cercaComputadora && Input.GetKeyDown(teclaInteraccion))
        {
            // Realizar la acción deseada al presionar la tecla de interacción
            AccionInteraccion();
        }
    }

    private void AccionInteraccion()
    {
        // Realizar la acción deseada al interactuar con la computadora
        Debug.Log("Interactuando con la computadora...");
        // Puedes agregar aquí la lógica para cambiar de cámara, activar una pantalla, etc.
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
