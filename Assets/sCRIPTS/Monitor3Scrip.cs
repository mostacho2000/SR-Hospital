using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor3Scrip : MonoBehaviour
{
    public GameObject panelADesactivar; // Panel 1
    public GameObject panel2; // Panel 2
    public GameObject panel3; // Panel 3
    public GameObject panel4; // Panel 4
    public Camera camaraJugador;
    public Camera camaraComputadora;
    private bool estaCercaDelJugador;
    private bool panelActivado;

    private FirstPersonController fpsController;

    private void Start()
    {
        fpsController = camaraJugador.GetComponentInParent<FirstPersonController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && estaCercaDelJugador)
        {
            if (camaraJugador != null && camaraComputadora != null)
            {
                bool isUsingComputer = camaraComputadora.enabled;

                camaraJugador.enabled = isUsingComputer;
                camaraComputadora.enabled = !isUsingComputer;

                Cursor.visible = !isUsingComputer;
                Cursor.lockState = isUsingComputer ? CursorLockMode.Locked : CursorLockMode.None;

                if (fpsController != null)
                {
                    if (isUsingComputer)
                    {
                        fpsController.RestoreSpeeds();
                    }
                    else
                    {
                        fpsController.SetSpeedsToZero();
                    }
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("EnteredSpace");
            estaCercaDelJugador = true;
            SetPanelsActive(true);
            panelActivado = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("ExitSpace");
            estaCercaDelJugador = false;
            SetPanelsActive(false);
            panelActivado = false;
        }
    }

    private void SetPanelsActive(bool isActive)
    {
        panelADesactivar.SetActive(isActive);
        panel2.SetActive(isActive);
        panel3.SetActive(isActive);
        panel4.SetActive(isActive);
    }
}
