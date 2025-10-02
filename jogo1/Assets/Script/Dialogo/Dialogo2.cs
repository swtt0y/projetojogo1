using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogo2 : MonoBehaviour
{
    public GameObject DialogoBox;
    public GameObject LataTexto;
    public GameObject ContasTexto;
    public GameObject CalendarioTexto;

    public void Lata()
    {
        ContasTexto.SetActive(false);
        CalendarioTexto.SetActive(false);
        DialogoBox.SetActive(true);
        LataTexto.SetActive(true);
    }

    public void Contas()
    {
        LataTexto.SetActive(false);
        CalendarioTexto.SetActive(false);
        DialogoBox.SetActive(true);
        ContasTexto.SetActive(true);
    }

    public void Calendario()
    {
        LataTexto.SetActive(false);
        ContasTexto.SetActive(false);
        DialogoBox.SetActive(true);
        CalendarioTexto.SetActive(true);
    }
}
