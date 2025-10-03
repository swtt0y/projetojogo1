using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelasFinais : MonoBehaviour
{
    public AudioClip vitoria;
    public AudioClip fundo;
    public void Start()
    {
       FindObjectOfType<MusicaFundo>().tocarMusicaUma(vitoria);

    }
    public void Menu()
   {
    SceneManager.LoadScene("menu");
   }

   public void Restart()
   {
        PlayerPrefs.DeleteAll();
        FindObjectOfType<MusicaFundo>().tocarMusicaUma(fundo);
        SceneManager.LoadScene("cena1");
   }
   public void Sair()
   {
    Application.Quit();
   }
}
