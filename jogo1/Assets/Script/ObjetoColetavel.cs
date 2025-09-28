using UnityEngine;

public class ObjetoColetavel : MonoBehaviour
{
    public int idObjeto;
    public bool podeColetar = true; // Voc� pode bloquear at� que alguma condi��o seja atendida

    void OnMouseDown()
    {
        if (podeColetar)
        {
            CameraColeta cameraColeta = Camera.main.GetComponent<CameraColeta>();
            cameraColeta.ColetarObjeto(idObjeto);
            Destroy(gameObject); // Some da cena ao coletar
        }
    }
}