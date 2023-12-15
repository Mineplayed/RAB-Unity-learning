using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    private float movementX;
    private float movementY;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementvalue)
    {
        Vector2 movementVecteur = movementvalue.Get<Vector2>();

        movementX = movementVecteur.x;
        movementY = movementVecteur.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement);
    }
}
