using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    bool cambio;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(LoadWinnerScene());
            Cursor.visible = !cambio;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private IEnumerator LoadWinnerScene()
    {
        // Cargar la escena asíncronamente
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Winner");

        // Esperar hasta que la escena haya terminado de cargar
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        
    }
}
