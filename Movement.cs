using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//oгоооогатдемнапотsoajfлоеаdsjghjdfhjgdfкрлывпварывррпв
public class Movement : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rb;
    Vector2 movementDirection;

    float horizInput;
    float vertInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizInput = Input.GetAxisRaw("Horizontal");
        vertInput = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        movementDirection = new Vector2(horizInput, vertInput).normalized;

        rb.MovePosition(rb.position + movementDirection * speed * Time.fixedDeltaTime);
    }
}
