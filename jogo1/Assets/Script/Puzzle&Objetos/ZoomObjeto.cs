using UnityEngine;

public class ZoomObjeto : MonoBehaviour
{
    private Vector3 escalaOriginal;
    private Vector3 posicaoOriginal;
    private bool ampliado = false;
    public Dialogo3 dialogo3;

    [SerializeField] private float fatorZoom = 2f;
    [SerializeField] private bool sempreNoCentro = false;
    [SerializeField] private Vector3 posicaoCentral = new Vector3(2, 2, 0); 

    void Start()
    {
        escalaOriginal = transform.localScale;
        posicaoOriginal = transform.position;
    }

    public void AtivarZoom()
    {
        if (!ampliado)
        {
            transform.localScale = escalaOriginal * fatorZoom;

            if (sempreNoCentro)
                transform.position = Vector3.zero; // centro da tela
            else
            {
                transform.position = posicaoCentral; // posi��o manual
                dialogo3.Padrao();
            }   
            ampliado = true;
            
        }
    }

    public void ResetarZoom()
    {
        transform.localScale = escalaOriginal;
        transform.position = posicaoOriginal;
        ampliado = false;
    }

    void OnMouseDown()
    {
        if (ampliado)
            ResetarZoom(); // permite fechar o zoom clicando
        
    }

}
