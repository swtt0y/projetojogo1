using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chave : MonoBehaviour
{
    public int idObjeto = 7;

    private void OnMouseDown()
    {
        CameraColeta cameraColeta = Camera.main.GetComponent<CameraColeta>();
        if (cameraColeta != null)
        {
            cameraColeta.ColetarObjeto(idObjeto);
            Debug.Log("chave coletada");
            Destroy(gameObject);
        }
    }
}
