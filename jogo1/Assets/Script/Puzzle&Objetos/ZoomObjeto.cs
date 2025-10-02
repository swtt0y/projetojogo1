using UnityEngine;

public class ZoomObjeto : MonoBehaviour
{
    private Vector3 escalaOriginal;
    private bool ampliado = false;

    [SerializeField] private float fatorZoom = 2f;
    [SerializeField] private bool sempreNoCentro = false;
    [SerializeField] private Vector3 posicaoCentral = new Vector3(2, 2, 0); 

    void Start()
    {
        if (PlayerPrefs.GetInt(gameObject.name, 0) == 1)
        {
            Destroy(gameObject); 
            return;
        }
        escalaOriginal = transform.localScale;
    }

    public void AtivarZoom()
    {
        if (!ampliado)
        {
            transform.localScale = escalaOriginal * fatorZoom;

            if (sempreNoCentro)
                transform.position = Vector3.zero; 
            else
                transform.position = posicaoCentral; 

            ampliado = true;
        }
    }

 
    void OnMouseDown()
    {
        if (ampliado)
        {
            PlayerPrefs.SetInt(gameObject.name, 1);
            Destroy(gameObject);
        }
         
    }
}
