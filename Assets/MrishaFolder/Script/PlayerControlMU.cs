using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControlMU : MonoBehaviour
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
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(mX, 0.0f, mY);

        rb.AddForce(movement * speed);
        //adding force adding physics 
        
    }

    public void OnMove(InputValue mV)
    {
        Vector2 vector2 = mV.Get<Vector2>();

        mX = vector2.x;
        mY = vector2.y;
    }
}
