using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timmerreflejar : MonoBehaviour
{
    public TextMeshProUGUI tiempoText;
    

    private void Start()
    {
        if (tiempoText != null)
        {
            tiempoText.text = Timer.instance.GetFormattedTime();
        }
    }

    public void LoadNewScene(string sceneName)
    {
        Timer.instance.PauseTimer(); // Pausar el cronómetro
        SceneManager.LoadScene(sceneName);
    }
   
}
