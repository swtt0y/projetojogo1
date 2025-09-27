using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioUI : MonoBehaviour
{
    public Transform slotsParent;
    private Image[] slotsImages;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
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

    // Update is called once per frame
    void Update()
    {
        if (slotsImages != null && slotsImages.Length > 0)
            UpdateUI();
    }
    public void UpdateUI()
    {
        if (slotsImages == null) return;

        for (int i = 0; i < slotsImages.Length; i++)
        {
            if (i < Inventario.instance.itens.Count)
            {
                if (Inventario.instance.itens[i].icone != null)
                {
                    slotsImages[i].sprite = Inventario.instance.itens[i].icone;
                    slotsImages[i].color = Color.white;
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

