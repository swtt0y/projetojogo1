using UnityEngine;

public class LocalDespejo : MonoBehaviour
{
    public int idAceito; 
    public GameObject objetoParaLiberar;
   
    public bool AceitaObjeto(int idObjeto)
    {
       if(idAceito==1 && idObjeto == 2)
        {
            return false;
        }
        return idObjeto == idAceito;
    }

    public void OnPuzzleResolve(int idObjeto)
    {
        if(AceitaObjeto(idObjeto))
        {
            objetoParaLiberar.SetActive(true);
            Debug.Log(" liberado");
        } 
        
    }

    void OnMouseDown()
    {
        CameraColeta cameraColeta = Camera.main.GetComponent<CameraColeta>();
        cameraColeta.DespejarObjeto(this);
    }
}