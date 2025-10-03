using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogo3 : MonoBehaviour
{
    public GameObject DialogoBox;
    public GameObject GatoTexto;
    public GameObject PadraoTexto;
    public GameObject SonicTexto;
    public GameObject ChaveTexto;
    public GameObject LivroTexto;

    public void Gato()
    {
        PadraoTexto.SetActive(false);
        SonicTexto.SetActive(false);
        ChaveTexto.SetActive(false);
        DialogoBox.SetActive(true);
        GatoTexto.SetActive(true);
    }

    public void Padrao()
    {
        GatoTexto.SetActive(false);
        SonicTexto.SetActive(false);
        ChaveTexto.SetActive(false);
        DialogoBox.SetActive(true);
        PadraoTexto.SetActive(true);
    }

    public void Sonic()
    {
        GatoTexto.SetActive(false);
        PadraoTexto.SetActive(false);
        ChaveTexto.SetActive(false);
        LivroTexto.SetActive(false);
        DialogoBox.SetActive(true);
        SonicTexto.SetActive(true);
    }

    public void Chave()
    {
        GatoTexto.SetActive(false);
        PadraoTexto.SetActive(false);
        SonicTexto.SetActive(false);
        DialogoBox.SetActive(true);
        ChaveTexto.SetActive(true);
    }

    public void Livro()
    {
        GatoTexto.SetActive(false);
        PadraoTexto.SetActive(false);
        SonicTexto.SetActive(false);
        ChaveTexto.SetActive(false);
        DialogoBox.SetActive(true);
        LivroTexto.SetActive(true);
    }
}
