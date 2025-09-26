using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public static Inventario inventario;
    public Lista<Item> itens = new Lista<Item>();
    public int tam = 10;

    void awake()
    {
        if (inventario == null) inventario = this;
    }

    public void Add(Item item)
    {
        itens.Add(item);
        Debug.Log(item.Nomeitem + " adicionado!");
    }


}

