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
}
