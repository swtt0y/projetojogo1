using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PuzzleLivros : MonoBehaviour
{
    public static PuzzleLivros Instance;

    private List<int> ordem = new List<int>{1,2,3,4,5,6,7,8};
    private List<int> tentativa = new List<int>();

    private void Awake()
    {
        if (Instance == null) 
        {
            Instance = this;
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    public void PegarClick(int id)
    {
        tentativa.Add(id);
        Debug.Log("Tentativa atual: " + string.Join(",", tentativa));

        if (tentativa.Count == ordem.Count)
        {
            Verificar();
        }
    }

    private void Verificar()
    {
        if (tentativa.SequenceEqual(ordem))
        {
            LiberarChave();
        }
        else
        {
            Debug.Log("Ordem incorreta! Tente novamente.");
            tentativa.Clear();
        }
    }

    public GameObject chave;

    public void LiberarChave()
    {
        if (chave !=null)
        {
            chave.SetActive(true);
            Debug.Log("Chave liberada!");
        }
    }
}
