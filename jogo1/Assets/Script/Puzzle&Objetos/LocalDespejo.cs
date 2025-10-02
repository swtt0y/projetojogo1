using System;
using JetBrains.Annotations;
using UnityEngine;

public class LocalDespejo : MonoBehaviour
{
    public int idAceito; 
    public GameObject objetoParaLiberar;
    public String nomeDoObjetoParaLiberar;
    public ObjetoColetavel proximoObjeto;
    public GameObject verificadorDoLocal;

    public bool AceitaObjeto(int idObjeto)
    {
        bool resultado = (idObjeto == idAceito);

        return resultado;
    }

    public void OnPuzzleResolve(int idObjeto)
    {
        if (!PlayerPrefs.HasKey(nomeDoObjetoParaLiberar))
        {
            Debug.Log("Objeto nunca foi coletado");

            if (PlayerPrefs.GetString(nomeDoObjetoParaLiberar) != "coletado")
            {
                Debug.Log("Objeto já utilizado anteriormente.");
                return;
            }
            return;
        }

        Debug.Log("Objeto coletado anteriormente.");

        if (AceitaObjeto(idObjeto))
        {
            if (objetoParaLiberar != null)
            {
                objetoParaLiberar.SetActive(true);
                ZoomObjeto zoom = objetoParaLiberar.GetComponent<ZoomObjeto>();
                if (zoom != null)
                {
                    zoom.AtivarZoom();
                }
                    
            }
                
            if (proximoObjeto != null)
            {
                proximoObjeto.podeColetar = true;
            }
                

            if (verificadorDoLocal != null)
            {
                verificadorDoLocal.SetActive(false);
            }

            Debug.Log("Puzzle resolvido e pr�ximo objeto liberado!");
            PlayerPrefs.SetString(nomeDoObjetoParaLiberar, "utilizado");
        }
        else
        {
            Debug.Log("Objeto n�o aceito!");
        }
            
        
    }


    void OnMouseDown()
    {
        Debug.Log("Clicou no local de despejo");
        OnPuzzleResolve(idAceito); // Apenas para teste
        //CameraColeta cameraColeta = Camera.main.GetComponent<CameraColeta>();
        //cameraColeta.DespejarObjeto(this);
    }
}