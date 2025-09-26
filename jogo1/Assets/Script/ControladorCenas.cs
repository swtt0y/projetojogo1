using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorCenas : MonoBehaviour
{
    public void esquerda()
    {
        SceneManager.LoadScene("cena2");
    }
}
