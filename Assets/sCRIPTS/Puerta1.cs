using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta1 : MonoBehaviour
{


    public GameObject puertaADestruir;
    private bool estaCercaDelJugador;

    private void Update()
    {
        // Verificar si se presiona la tecla "E"
        if (Input.GetKeyDown(KeyCode.E) && estaCercaDelJugador)
        {
            // Destruir la puerta
            Destroy(puertaADestruir);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("EnteredSpace");
            estaCercaDelJugador = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("ExitSpace");
            estaCercaDelJugador = false;
        }
    }
}
