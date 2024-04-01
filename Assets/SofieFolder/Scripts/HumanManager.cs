using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    public GameObject human;
    public float value;
    public Vector3 sizeChange;


    public void  MoveLeft()
    {
        value = value - 1;
        human.transform.position = new Vector3(value, -6, 15);
    }

    public void MoveRight()
    {
        value = value + 1;
        human.transform.position = new Vector3(value, -6, 15);
    }

    public void RotateLeft()
    {
        human.transform.Rotate(0f, 20f, 0f);
    }

    public void RotateRight()
    {
        human.transform.Rotate(0f, -20f, 0f);
    }

    public void Grow()
    {
        human.transform.localScale = human.transform.localScale + sizeChange;       
    }

    public void Shrink()
    {
        human.transform.localScale = human.transform.localScale - sizeChange;
    }

    public void Reset()
    {
        human.transform.position = new Vector3(0, -6, 15);
        human.transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
        human.transform.localScale = new Vector3(1, 1, 1);
    }

}
