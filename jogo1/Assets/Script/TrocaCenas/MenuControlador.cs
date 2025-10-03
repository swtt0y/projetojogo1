using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControlador : MonoBehaviour
{
    public AudioClip musicamenu;
    private void Start()
    {
        FindObjectOfType<MusicaFundo>().trocarMusica(musicamenu);
    }
    public void Jogar()
    {
        SceneManager.LoadScene("cena1");
    }
    public GameObject infos;

    public void Info()
    {   
        infos.SetActive(true);
    }

    public void InfoOff()
    {
        infos.SetActive(false);
    }

    public void Sair()
    {
        Application.Quit();
    }

    
}
