using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VitoriaDerrota : MonoBehaviour
{
    public Button[] botoes;
    public int vitoria = 1;
    public Button confirma;
    private int selecionado = -1;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < botoes.Length; i++)
        {
            int index = i;
            botoes[i].onClick.AddListener(() => SelecionarBotao(index));
        }
        confirma.onClick.AddListener(ConfirmarEscolha);
    }

    void SelecionarBotao(int index)
    {
        selecionado = index;
        Debug.Log(botoes[index].name);

        for (int i = 0; i < botoes.Length; i++)
        {
            Transform check = botoes[i].transform.Find("check");
            if (check != null)
                check.gameObject.SetActive(i == selecionado);

        }


    }
    void ConfirmarEscolha()
    {
        if (selecionado == -1)
        {
            Debug.Log("Nenhum botão selecionado!");
            return;
        }

        if (selecionado == vitoria)
        {
            Debug.Log("Você acertou!");
        }

        else
        {
            Debug.Log("Botão errado!");
        }


    }
}

