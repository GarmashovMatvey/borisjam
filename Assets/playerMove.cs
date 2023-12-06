using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    private delegate void Events();
    Events events;
    private Rigidbody2D rb;
    public float moveSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl)){
            events += move;
        }
        else if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            events -= move;
        }
    }

    void FixedUpdate()
    {
        events.Invoke();
    }

    void move()
    {
        float horInput = Input.GetAxisRaw("Horizontal");
        float verInput = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(horInput*moveSpeed, verInput*moveSpeed);
    }
}
