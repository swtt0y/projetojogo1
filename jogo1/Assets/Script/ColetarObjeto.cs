using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetarObjeto : MonoBehaviour
{
    public float distanciaMaxima = 10f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 posicao = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(posicao, Vector2.zero, distanciaMaxima);

            if (hit.collider != null) 
            {
                if (hit.collider.CompareTag("Coletavel")) 
                {
                    Coletavel c = hit.collider.GetComponent<Coletavel>();
                    c.Coletar();
                    Inventario.inventario.Add(c);
                }
            }
        }
    }
}
