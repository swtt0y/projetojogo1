using UnityEngine;

public class TestClick : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("Clique detectado em: " + gameObject.name);
    }
}
