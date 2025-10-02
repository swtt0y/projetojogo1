using UnityEngine;

public class ObjetoColetavel : MonoBehaviour
{
    public int idObjeto;
    public bool podeColetar = true; // Voc� pode bloquear at� que alguma condi��o seja atendida
    public string nomeDoObjeto;
    public Dialogo2 dialogo2;
    

    void Awake()
    {
        if (PlayerPrefs.HasKey(nomeDoObjeto))
        {
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        if (!podeColetar) return;

        // Pega a refer�ncia da c�mera
        CameraColeta cameraColeta = Camera.main.GetComponent<CameraColeta>();
        
        if (cameraColeta != null)
        {
            if (idObjeto == 1)
            {
                dialogo2.Lata();
            }
            
            cameraColeta.ColetarObjeto(idObjeto);
            PlayerPrefs.SetString(nomeDoObjeto, "coletado");
    
            Debug.Log("Objeto coletado: " + gameObject.name);
        }
        // Destr�i o GameObject imediatamente
        Destroy(gameObject);
    }
}
    
