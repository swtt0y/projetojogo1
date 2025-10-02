using UnityEngine;

public class ObjetoColetavel : MonoBehaviour
{
    public int idObjeto;
    public bool podeColetar = true; 
    public string nomeDoObjeto;

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

        
        CameraColeta cameraColeta = Camera.main.GetComponent<CameraColeta>();

        if (cameraColeta != null)
        {
            cameraColeta.ColetarObjeto(idObjeto);
            PlayerPrefs.SetString(nomeDoObjeto, "coletado");
            
            Debug.Log("Objeto coletado: " + gameObject.name);
        }
        
        
        Destroy(gameObject);
    }
}
    
