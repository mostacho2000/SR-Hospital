using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMenu : MonoBehaviour
{
    public void jugar()
    {

        SceneManager.LoadScene("CharlySRHospital");
       

    }
    public void controles()
    {

        SceneManager.LoadScene("controles");

    }
    public void INICIO()
    {

        SceneManager.LoadScene("MenuInicio");

    }

    public void Creditos()
    {

        SceneManager.LoadScene("Creditos");

    }

    public void MenuSalir()
    {
        SceneManager.LoadScene("ExitMenu");
        
        


    }

    public void Salir()
    {

        Debug.Log("Salir...");
        Application.Quit();

    }
}
