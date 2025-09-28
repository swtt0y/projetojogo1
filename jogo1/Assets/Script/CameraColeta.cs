using UnityEngine;

public class CameraColeta : MonoBehaviour
{
    public int objetoNaMao = -1; 

    public void ColetarObjeto(int idObjeto)
    {
        objetoNaMao = idObjeto;
    }

    public void DespejarObjeto(LocalDespejo local)
    {
        if (objetoNaMao != -1 && local.AceitaObjeto(objetoNaMao))
        {
         
            objetoNaMao = -1;

        }
    }
}