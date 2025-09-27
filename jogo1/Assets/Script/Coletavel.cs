using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public string identificador;
    public Sprite icone;
    public string descricao;

    void Start() 
    {
        if (Inventario.inventario != null && Inventario.inventario.JaTem(this)) 
        {
            gameObject.SetActive(false);
        }
    }
    public void Coletar()
    {
        Inventario.inventario.Add(this);
        gameObject.SetActive(false);
        Debug.Log(identificador + " foi coletado.");
    }
}
