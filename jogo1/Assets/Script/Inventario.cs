using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public static Inventario inventario;
    public List<Coletavel> itens = new List<Coletavel>();

    void Awake()
    {
        if(inventario==null)
        {
            inventario = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    public void Add(Coletavel item)
    {
        if (!itens.Contains(item)) {
            itens.Add(item);
            Debug.Log(item.name + " adicionado!");

            if (InventarioUI.instance != null) {
                InventarioUI.instance.UpdateUI();
            }
        }
    }

    public bool JaTem(Coletavel item)
    {
        return itens.Contains(item);
    }
}

