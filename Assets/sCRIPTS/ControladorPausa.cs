using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPausa : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;

    // Este método será llamado cuando el botón del panel 1 sea presionado
    public void SwitchToPanel2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }

    // Este método será llamado cuando el botón del panel 2 sea presionado
    public void SwitchToPanel1()
    {
        panel2.SetActive(false);
        panel1.SetActive(true);
    }
}
