using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    public float velocidadGiro = 180f;
    public float fuerzaSalto = 8f;

    private CharacterController characterController;
    private Transform camaraTransform;
    private float gravedad = 9.8f;
    private float velocidadVertical;

    private void Start()
    {
        // Obtener referencias a los componentes y configuración inicial
        characterController = GetComponent<CharacterController>();
        camaraTransform = Camera.main.transform;
        Cursor.lockState = CursorLockMode.Locked;//congela el cursor en el centro
        Cursor.visible = false;//desaparece el cursor
    }

    private void Update()
    {
        // Lógica de control principal, llamada en cada fotograma
        // Gestiona el movimiento, rotación de la cámara, gravedad y salto del jugador
        MoverJugador();
        RotarCamara();
        AplicarGravedad();

        // Saltar cuando se presiona la tecla de salto y el jugador está en el suelo
        if (Input.GetButtonDown("Jump") && characterController.isGrounded)
        {
            Saltar();
        }
    }

    private void MoverJugador()
    {
        // Mueve al jugador en la dirección deseada en función de las entradas de teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = transform.TransformDirection(new Vector3(movimientoHorizontal, 0, movimientoVertical)) * velocidadMovimiento;
        characterController.Move(movimiento * Time.deltaTime);
    }

    private void RotarCamara()
    {
        // Rota la cámara alrededor del jugador en el eje Y en función del movimiento del mouse
        float rotacionX = Input.GetAxis("Mouse X") * velocidadGiro * Time.deltaTime;
        float rotacionY = Input.GetAxis("Mouse Y") * 50 * Time.deltaTime;
        transform.Rotate(Vector3.up * rotacionX);
        camaraTransform.Rotate(Vector3.left*rotacionY);
    }

    private void AplicarGravedad()
    {
        // Aplica la gravedad al jugador, simulando su caída
        if (!characterController.isGrounded)
        {
            velocidadVertical -= gravedad * Time.deltaTime;
        }
        else
        {
            velocidadVertical = -gravedad * 0.5f;
        }

        Vector3 gravedadVector = new Vector3(0, velocidadVertical, 0);
        characterController.Move(gravedadVector * Time.deltaTime);
    }

    private void Saltar()
    {
        // Realiza un salto aplicando una velocidad vertical inicial
        velocidadVertical = Mathf.Sqrt(fuerzaSalto * 2f * gravedad);
    }
}
