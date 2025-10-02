using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelasFinais : MonoBehaviour
{
   public void Menu()
   {
    SceneManager.LoadScene("menu");
   }

   public void Restart()
   {
    PlayerPrefs.DeleteAll();
    SceneManager.LoadScene("cena1");
   }
   public void Sair()
   {
    Application.Quit();
   }
}
