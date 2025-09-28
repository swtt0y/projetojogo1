using UnityEngine;

public class ObjetoColetavel : MonoBehaviour
{
    public int idObjeto;
    public bool podeColetar = true; // Voc� pode bloquear at� que alguma condi��o seja atendida

    void OnMouseDown()
    {
        if (!podeColetar) return;

        // Pega a refer�ncia da c�mera
        CameraColeta cameraColeta = Camera.main.GetComponent<CameraColeta>();

        if (cameraColeta != null)
        {
            cameraColeta.ColetarObjeto(idObjeto);
            Debug.Log("Objeto coletado: " + gameObject.name);
        }

        // Destr�i o GameObject imediatamente
        Destroy(gameObject);
    }
}
    
