using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public static Inventario instance;

    public List<DadosItem> itens = new List<DadosItem>();
    public int capacidade = 5;

    // Armazena IDs de objetos coletados
    public HashSet<string> objetosColetados = new HashSet<string>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AdicionarItem(DadosItem item, string atualID = null)
    {
        if (itens.Count >= capacidade) return;

        itens.Add(item);

        if (!string.IsNullOrEmpty(atualID))
        {
            objetosColetados.Add(atualID); 
        }
        if (InventarioUI.instance != null) InventarioUI.instance.UpdateUI();
    }

    public bool FoiColetado(string atualID)
    {
        return objetosColetados.Contains(atualID);
    }

}
