using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public float jumpforce;
    public Rigidbody2D rig;

    float direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("horizontal");
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            rig.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
        }
    }
    void FixedUpdate()
    {
        rig.velocity = new Vector2(direction * speed, rig.velocity.y);
    }
}
