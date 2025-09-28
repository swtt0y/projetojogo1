using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemColetavel : MonoBehaviour
{
    public DadosItem dadosItem;
    public string atualID;

    void Start()
    {
        if (Inventario.instance != null && Inventario.instance.FoiColetado(atualID))
        {
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        if (dadosItem != null)
        {
            Inventario.instance.AdicionarItem(dadosItem, atualID);
            Destroy(gameObject);
        }
    }
}
