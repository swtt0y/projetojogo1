using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioUI : MonoBehaviour
{
     public static InventarioUI instance;

    [Tooltip("Painel que contém apenas os slots (filhos diretos devem ser os Images dos slots).")]
    public Transform slotsParent;

    private List<Image> slotsImages = new List<Image>();

    void Awake()
    {
        // Singleton
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }

        // validação
        if (slotsParent == null)
        {
            Debug.LogError("InventarioUI: atribua slotsParent no Inspector!");
            return;
        }

        // pega todas as Images dentro do painel, mas filtra só os filhos diretos (evita pegar o background do painel)
        slotsImages.Clear();
        Image[] all = slotsParent.GetComponentsInChildren<Image>(true);
        foreach (Image img in all)
        {
            slotsImages.Add(img);
        }

        if (slotsImages.Count == 0)
            Debug.LogWarning("InventarioUI: nenhum Image encontrado como filho direto de slotsParent. Verifique a hierarquia.");

        // atualiza UI já no Awake
        UpdateUI();
    }

    // chama publicamente quando o inventário mudar
    public void UpdateUI()
    {
        if (Inventario.instance == null) return;
        if (slotsImages == null || slotsImages.Count == 0) return;

        for (int i = 0; i < slotsImages.Count; i++)
        {
            Image slot = slotsImages[i];

            if (i < Inventario.instance.itens.Count)
            {
                var item = Inventario.instance.itens[i]; // ItemData ou classe que você usa
                if (item != null && item.icone != null)
                {
                    slot.sprite = item.icone;
                    slot.color = Color.white;
                }
                else
                {
                    slot.sprite = null;
                    slot.color = new Color(1, 1, 1, 0);
                }
            }
            else
            {
                slot.sprite = null;
                slot.color = new Color(1, 1, 1, 0);
            }
        }
    }

    // método auxiliar para debug rápido
    [ContextMenu("LogSlots")]
    void LogSlots()
    {
        Debug.Log($"InventarioUI: slots count = {slotsImages.Count}");
        for (int i=0;i<slotsImages.Count;i++) Debug.Log($"Slot {i}: {slotsImages[i].name}");
    }

}
