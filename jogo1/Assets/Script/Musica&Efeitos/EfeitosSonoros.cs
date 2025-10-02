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
        audioSource.playOnAwake = false; 
    }

    
    public void TocarSom()
    {
        if (efeito != null && audioSource != null)
        {
            audioSource.PlayOneShot(efeito, 1f);
        }
       
    }

}

