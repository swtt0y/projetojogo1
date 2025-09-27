using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public static Inventario instance;
    public List<Item> itens = new List<Item>();

    void Awake()
    {
        if(instance==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    public void Add(Item item)
    {
        itens.Add(item);
        Debug.Log(item.nameItem + " adicionado!");
       
    }

    public void Remove(Item item)
    {
        if (itens.Contains(item)) 
        {
            itens.Remove(item);
            Debug.Log(item.nameItem + " removido!");
        }
    }

}

