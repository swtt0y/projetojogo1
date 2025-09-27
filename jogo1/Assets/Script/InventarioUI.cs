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
            DontDestroyOnLoad(gameObject);

            InitializeUI();
        }
        else if (instance != this)
        {
            
            Destroy(gameObject);
            return; 
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
    }

    void InitializeUI()
    {
        if (slotsParent == null)
        {
            Debug.LogError("SlotsParent n�o atribu�do no Inspector!");
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
        
        if (Inventario.inventario == null) return;

        if (slotsImages == null) return;

        for (int i = 0; i < slotsImages.Length; i++)
        {
            if (i < Inventario.inventario.itens.Count)
            {
                
                if (Inventario.inventario.itens[i] != null)
                {
                    
                    if (Inventario.inventario.itens[i].icone != null) 
                    {
                        slotsImages[i].sprite = Inventario.inventario.itens[i].icone;
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
            else
            {
                
                slotsImages[i].sprite = null;
                slotsImages[i].color = new Color(1, 1, 1, 0);
            }
        }
    }
}


