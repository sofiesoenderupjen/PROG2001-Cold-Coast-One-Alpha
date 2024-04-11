using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerControlMU : MonoBehaviour
{
    private Rigidbody rb;

    private float mX;
    private float mY;

    public float speed = 0;

    public TextMeshProUGUI countText;

    private float Count;

    public GameObject winPanel;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Count = 0;
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

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag ("Pickup"))
        {
            other.gameObject.SetActive(false);
            Count += 1;

            SetCountText();
        }
    }

    public void SetCountText()
    {
        countText.text = "Count: " + Count.ToString();
        //ask Adam 
    }

    public void CheckScore()
    {
        //for 6 coins = 6 

        if (Count == 6)
        {
            winPanel.SetActive(true);
        }
    }
}
