using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IdLivro : MonoBehaviour, IPointerClickHandler
{
    public int idLivro;

    public void OnPointerClick(PointerEventData eventData)
    {
        PuzzleLivros.Instance.PegarClick(idLivro);
    }
    /*
    private List<int> ordem = new List<int> {1, 2, 3, 4, 5, 6, 7, 8}; 
    private List<int> tentativa = new List<int>();
    private int limite = 8;

    public void LerTentativa()
    {
        if (tentativa.Count < limite)
        {
            tentativa.Add(idLivro);
            Debug.Log("adicionado");
        }
        if (tentativa.Count >= limite)
        {
            Comparar();
        }
    }
    public void Comparar()
    {
        bool resultado = tentativa.SequenceEqual(ordem);
        if (resultado)
        {
            LiberarChave();
        }
        else 
        {
            tentativa.Clear();
        }
    }
    public void LiberarChave()
    {
        CameraColeta cameraColeta = Camera.main.GetComponent<CameraColeta>();
        cameraColeta.ColetarObjeto(7);
    }
    */
}
