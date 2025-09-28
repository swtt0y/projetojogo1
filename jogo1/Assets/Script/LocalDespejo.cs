using JetBrains.Annotations;
using UnityEngine;

public class LocalDespejo : MonoBehaviour
{
    public int idAceito; 
    public GameObject objetoParaLiberar;
    public ObjetoColetavel proximoObjeto;
    public GameObject verificadorDoLocal;

    public bool AceitaObjeto(int idObjeto)
    {
        bool resultado = (idObjeto == idAceito);

        return resultado;
    }

    public void OnPuzzleResolve(int idObjeto)
    {
        if (AceitaObjeto(idObjeto))
        {
            if (objetoParaLiberar != null)
                objetoParaLiberar.SetActive(true);

            if (proximoObjeto != null)
                proximoObjeto.podeColetar = true;

           
            if (verificadorDoLocal != null)
                verificadorDoLocal.SetActive(false);

            Debug.Log("Puzzle resolvido e próximo objeto liberado!");
        }
        else
        {
            Debug.Log("Objeto não aceito!");
        }
    }


    void OnMouseDown()
    {
 
        CameraColeta cameraColeta = Camera.main.GetComponent<CameraColeta>();
        cameraColeta.DespejarObjeto(this);
    }
}