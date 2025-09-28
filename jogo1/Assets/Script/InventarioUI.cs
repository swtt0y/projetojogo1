using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioUI : MonoBehaviour
{
    public static InventarioUI instance;
    public Transform slotsParent;   
    private Image[] slotsImages;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            InitializeUI();
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }
        InitializeUI();
    }

    void InitializeUI()
    {
        if (slotsParent == null)
        {
            Debug.LogError("SlotsParent não atribuído no Inspector!");
            return;
        }

        slotsImages = slotsParent.GetComponentsInChildren<Image>();
        if (slotsImages.Length == 0)
        {
            Debug.LogError("Nenhum slot Image encontrado como filho de slotsParent!");
        }

        
        UpdateUI();
    }

   
    public void UpdateUI()
    {
        if (Inventario.inventario == null || slotsImages == null) return;

        for (int i = 0; i < slotsImages.Length; i++)
        {
            if (i < Inventario.inventario.itens.Count)
            {
                var item = Inventario.inventario.itens[i];
                if (item != null && item.icone != null)
                {
                    slotsImages[i].sprite = item.icone;
                    slotsImages[i].color = Color.white;
                }
                else
                {
                    slotsImages[i].sprite = null;
                    slotsImages[i].color = new Color(1, 1, 1, 0);
                }
            }
            else
            {
                slotsImages[i].sprite = null;
                slotsImages[i].color = new Color(1, 1, 1, 0);
            }
        }
    }
}
