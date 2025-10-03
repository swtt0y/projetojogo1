using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaFundo : MonoBehaviour
{
    private static MusicaFundo instance;
    public AudioSource audioSource;
    public AudioClip musicaFundo;

    void Start()
    {
        if (instance != null && instance!=this)
        { 
            Destroy(gameObject);
        return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
        
        if (audioSource != null && musicaFundo!= null)
        {
            audioSource.clip = musicaFundo;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public void trocarMusica(AudioClip novaMusica)
    {
        if (audioSource.clip == novaMusica) return;

        audioSource.Stop();
        audioSource.clip = novaMusica;
        audioSource.Play();
    }

    public void pararMusica()
    {
        if (audioSource.isPlaying)
            audioSource.Stop();
    }
    public void tocarMusicaUma(AudioClip clip)
    {
        if (clip == null || audioSource == null) return;

        audioSource.Stop();
        audioSource.clip = clip;
        audioSource.loop = false; 
        audioSource.Play();
    }
}
