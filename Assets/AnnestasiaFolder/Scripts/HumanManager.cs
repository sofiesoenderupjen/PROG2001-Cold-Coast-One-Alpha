using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    public GameObject princess;
    public float value;
    public Vector3 sizeChange;

    public void MoveLeft()
    {
        value = value - 0.1f;
        princess.transform.position = new Vector3(value, 0, -5);

    }


    public void MoveRight()
    {
        value = value + 0.1f;
        princess.transform.position = new Vector3(value, 0, -5);
    }

    public void RotateLeft()
    {
        princess.transform.Rotate(0f, 20f, 0f);
    }

    public void RotateRight()
    {
        princess.transform.Rotate(0f, -20f, 0f);
    }


    public void Grow()
    {
        princess.transform.localScale = princess.transform.localScale + sizeChange;
    }

    public void Shrink()
    {
        princess.transform.localScale = princess.transform.localScale - sizeChange;
    }

    public void Reset()
    {
        princess.transform.position = new Vector3(0, 0, -5);
        princess.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        princess.transform.localScale = new Vector3(1, 1, 1);
    }
}
