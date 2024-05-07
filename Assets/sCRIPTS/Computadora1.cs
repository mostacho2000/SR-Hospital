using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computadora1 : MonoBehaviour
{
    public GameObject panelADesactivar;
    public Camera camaraJugador;
    public Camera camaraComputadora;
    private bool estaCercaDelJugador;
    private bool panelActivado;

    private void Update()
    {
        // Verificar si se presiona la tecla "E" y el jugador está cerca
        if (Input.GetKeyDown(KeyCode.E) && estaCercaDelJugador)
        {
            // Cambiar entre las cámaras
            if (camaraJugador != null && camaraComputadora != null)
            {
                camaraJugador.enabled = !camaraJugador.enabled;
                camaraComputadora.enabled = !camaraComputadora.enabled;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("EnteredSpace");
            estaCercaDelJugador = true;

            // Activar el panel al detectar al jugador cerca
            panelADesactivar.SetActive(true);
            panelActivado = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("ExitSpace");
            estaCercaDelJugador = false;

            // Desactivar el panel al salir el jugador
            panelADesactivar.SetActive(false);
            panelActivado = false;
        }
    }
}