using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class MariannesHumanManager : MonoBehaviour
{
    public GameObject girl;
    public float value;
    public Vector3 sizeChange;

    public void MoveLeft()
    {
        value = value - 1;
        girl.transform.position = new Vector3(value, -11, 24);
    }

    public void MoveRight()
    {
        value = value + 1;
        girl.transform.position = new Vector3(value, -11, 24);
    }

    public void RotateLeft()
    {
        girl.transform.Rotate(value, -20f, 0f); //x,y,z
    }

    public void RotateRight()
    {
        girl.transform.Rotate(value, 20f, 0f); //x,y,z
    }

    public void Grow()
    {
        girl.transform.localScale = girl.transform.localScale + sizeChange;
    }

    public void Shrink()
    {
        girl.transform.localScale = girl.transform.localScale - sizeChange;
    }

    public void Reset()
    {
        girl.transform.position = new Vector3(0, -11, 24);
        girl.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        girl.transform.localScale = new Vector3(1, 1, 1);
    }
}
