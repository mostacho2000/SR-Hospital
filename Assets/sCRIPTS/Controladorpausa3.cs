using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controladorpausa3 : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3; // Nuevo panel 3
    public GameObject panel4;
    public GameObject panel5;// Nuevo panel 4
    [SerializeField] AudioSource _audio;

    public GameObject objectToDestroy;

    // Método para cambiar del panel 1 al panel 2
    public void SwitchToPanel2()
    {
        _audio.Play();
        SetActivePanel(panel2);
    }

    // Método para cambiar del panel 2 al panel 1
    public void SwitchToPanel1()
    {
        _audio.Play();
        SetActivePanel(panel1);
    }

    // Método para cambiar del panel 1 al panel 3
    public void SwitchToPanel3()
    {
        _audio.Play();
        SetActivePanel(panel3);
    }

    // Método para cambiar del panel 1 al panel 4
    public void SwitchToPanel4()
    {
        _audio.Play();
        SetActivePanel(panel4);
    }

    public void SwitchToPanel5()
    {
        _audio.Play();
        SetActivePanel(panel5);
    }

    // Método para cambiar del panel 2 al panel 3
    public void SwitchToPanelFrom2To3()
    {
        _audio.Play();
        SetActivePanel(panel3);
    }

    // Método para cambiar del panel 2 al panel 4
    public void SwitchToPanelFrom2To4()
    {
        _audio.Play();
        SetActivePanel(panel4);
    }

    // Método para cambiar del panel 3 al panel 4
    public void SwitchToPanelFrom3To4()
    {
        _audio.Play();
        SetActivePanel(panel4);
    }

    // Método para cambiar del panel 3 al panel 1
    public void SwitchToPanelFrom3To1()
    {
        _audio.Play();
        SetActivePanel(panel1);
    }

    // Método para cambiar del panel 4 al panel 1
    public void SwitchToPanelFrom4To1()
    {
        _audio.Play();
        SetActivePanel(panel1);
    }

    // Método para cambiar del panel 4 al panel 2
    public void SwitchToPanelFrom4To2()
    {
        _audio.Play();
        SetActivePanel(panel2);
    }

    // Método para cambiar del panel 4 al panel 3
    public void SwitchToPanelFrom4To3()
    {
        _audio.Play();
        SetActivePanel(panel3);
    }

    // Método privado para establecer el panel activo
    private void SetActivePanel(GameObject activePanel)
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);

        activePanel.SetActive(true);
    }

    public void DestroyGameObject(GameObject gameObjectToDestroy)
    {
        if (gameObjectToDestroy != null)
        {
            Destroy(gameObjectToDestroy);
        }
    }

}
