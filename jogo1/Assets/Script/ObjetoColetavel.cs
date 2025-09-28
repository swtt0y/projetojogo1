using UnityEngine;

public class ObjetoColetavel : MonoBehaviour
{
    public int idObjeto;
    public bool podeColetar = true; // Você pode bloquear até que alguma condição seja atendida

    void OnMouseDown()
    {
        if (!podeColetar) return;

        // Pega a referência da câmera
        CameraColeta cameraColeta = Camera.main.GetComponent<CameraColeta>();

        if (cameraColeta != null)
        {
            cameraColeta.ColetarObjeto(idObjeto);
            Debug.Log("Objeto coletado: " + gameObject.name);
        }

        // Destrói o GameObject imediatamente
        Destroy(gameObject);
    }
}
    
