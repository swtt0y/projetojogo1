using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaFundo : MonoBehaviour
{
    private static MusicaFundo instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        { 
            Destroy(gameObject);
        return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
