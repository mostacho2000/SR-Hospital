using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMenu : MonoBehaviour
{
    [SerializeField]AudioSource _audio;
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
}
