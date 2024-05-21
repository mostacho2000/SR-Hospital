using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sistemaDeParticulas : MonoBehaviour
{
    public ParticleSystem particleSystem; // Arrastra aquí el sistema de partículas desde el inspector

    void OnTriggerEnter(Collider other)
    {
        // Verifica si el sistema de partículas no es nulo
        if (particleSystem != null)
        {
            // Activa el sistema de partículas
            particleSystem.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Verifica si el sistema de partículas no es nulo
        if (particleSystem != null)
        {
            // Detiene el sistema de partículas
            particleSystem.Stop();
        }
    }
}
