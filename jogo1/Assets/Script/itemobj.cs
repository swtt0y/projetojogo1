using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemobj : MonoBehaviour
{
    public Item item;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Trigger entrou com: " + collision.name);
            Inventario.instance.Add(item);
            Destroy(gameObject);
        }
    }
}
