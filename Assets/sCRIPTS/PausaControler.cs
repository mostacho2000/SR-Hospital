using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class PausaControler : MonoBehaviour
{
    public GameObject panelADesactivar;
    public Camera camaraJugador;
    public Camera camaraPausa;
    private bool estaCercaDelJugador;
    private bool panelActivado;
    private bool camaraPausaActiva;
    AudioSource _audio;

    private FirstPersonController fpsController;

    private void Start()
    {
        _audio = GetComponent<AudioSource>();
        fpsController = camaraJugador.GetComponentInParent<FirstPersonController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && estaCercaDelJugador)
        {
            ToggleCamera();
        }
    }

    private void ToggleCamera()
    {
        if (camaraJugador != null && camaraPausa != null)
        {
            camaraPausaActiva = !camaraPausaActiva;

            camaraJugador.enabled = !camaraPausaActiva;
            camaraPausa.enabled = camaraPausaActiva;

            Cursor.visible = camaraPausaActiva;
            Cursor.lockState = camaraPausaActiva ? CursorLockMode.None : CursorLockMode.Locked;

            if (fpsController != null)
            {
                if (camaraPausaActiva)
                {
                    fpsController.SetSpeedsToZero();
                }
                else
                {
                    fpsController.RestoreSpeeds();
                }
            }

            Debug.Log("Cámara cambiada. camaraJugador: " + camaraJugador.enabled + ", camaraPausa: " + camaraPausa.enabled);
        }
    }

    public void SimulateEscapePress()
    {
        if (estaCercaDelJugador)
        {
            ToggleCamera();
            _audio.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("EnteredSpace");
            estaCercaDelJugador = true;
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
            panelADesactivar.SetActive(false);
            panelActivado = false;
        }
    }
}
