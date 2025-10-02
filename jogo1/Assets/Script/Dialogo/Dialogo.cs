using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogo : MonoBehaviour
{
    public GameObject DialogoBox;
    public GameObject GavetaTexto;
    public GameObject JTexto;
    public GameObject MTexto;
    public GameObject CTexto;
    public GameObject CartaPanel;

    public void gavetaTexto()
    {
        JTexto.SetActive(false);
        CTexto.SetActive(false);
        MTexto.SetActive(false);
        DialogoBox.SetActive(true);
        GavetaTexto.SetActive(true);
    }

    public void quadroJ()
    {
        GavetaTexto.SetActive(false);
        CTexto.SetActive(false);
        MTexto.SetActive(false);
        DialogoBox.SetActive(true);
        JTexto.SetActive(true);
    }

    public void quadroM()
    {
        GavetaTexto.SetActive(false);
        JTexto.SetActive(false);
        CTexto.SetActive(false);
        DialogoBox.SetActive(true);
        MTexto.SetActive(true);
    }

    public void C()
    {
        GavetaTexto.SetActive(false);
        JTexto.SetActive(false);
        MTexto.SetActive(false);
        DialogoBox.SetActive(true);
        CTexto.SetActive(true);
    }

    public void carta()
    {
        GavetaTexto.SetActive(false);
        JTexto.SetActive(false);
        MTexto.SetActive(false);
        DialogoBox.SetActive(false);
        CTexto.SetActive(false);
        CartaPanel.SetActive(true);
    }
    public void cartaOff()
    {
        CartaPanel.SetActive(false);
    }
}
