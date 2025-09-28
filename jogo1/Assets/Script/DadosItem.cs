using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Novo Objeto", menuName = "Inventario/Novo Item")]
public class DadosItem : ScriptableObject
{
    public string IdItem;
    public string nomeItem;
    public Sprite icone;
    [TextArea] public string descricaoItem;
}
