using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMenu : MonoBehaviour
{
    [SerializeField]AudioSource _audio;
    bool cambio;
    public void ChangeScene(string name)
    {
        StartCoroutine(Time(name));
    }

    public void Salir()
    {
        _audio.Play();
        Debug.Log("Salir...");
        Application.Quit();
    }
    IEnumerator Time(string nameScene)
    {
        _audio.Play();
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene(nameScene);
    }
    public void inicio()
    {
        SceneManager.LoadScene("OmarSRHospital");
        Cursor.visible = cambio;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
