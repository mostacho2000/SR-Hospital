using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorLuz : MonoBehaviour
{
    public Light spotlight; // Asigna el spotlight en el Inspector
    public ParticleSystem particleSystem; // Asigna el sistema de partículas en el Inspector
    private float minInterval = 3f;
    private float maxInterval = 8f;

    void Start()
    {
        if (spotlight == null)
        {
            Debug.LogError("No spotlight assigned!");
            return;
        }

        if (particleSystem == null)
        {
            Debug.LogError("No particle system assigned!");
            return;
        }

        StartCoroutine(ToggleRoutine());
    }

    IEnumerator ToggleRoutine()
    {
        while (true)
        {
            // Espera un tiempo aleatorio entre minInterval y maxInterval
            float waitTime = Random.Range(minInterval, maxInterval);
            yield return new WaitForSeconds(waitTime);

            // Alterna el estado de la luz
            spotlight.enabled = !spotlight.enabled;

            // Alterna el estado del sistema de partículas
            if (particleSystem.isPlaying)
            {
                particleSystem.Stop();
            }
            else
            {
                particleSystem.Play();
            }
        }
    }
}
