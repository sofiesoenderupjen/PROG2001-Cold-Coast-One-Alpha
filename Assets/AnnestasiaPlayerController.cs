using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnnestasiaPlayerController : MonoBehaviour
{

    private Rigidbody rb;
    private float mX;
    private float mY;
    public float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate() //fixed update is used when you need to calculate physics
    {
        Vector3 movement = new Vector3(mX, 0.0f, mY);
        rb.AddForce(movement * speed);
    }

    public void OnMove(InputValue movementValue)
    {
        Vector2 moveV = movementValue.Get<Vector2>();

        mX = moveV.x;
        mY = moveV.y;
    }
}