using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class EfeitosSonoros : MonoBehaviour
{
    public AudioClip efeito;      
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    
    public void TocarSom()
    {

       audioSource.PlayOneShot(efeito);
       
    }

}

