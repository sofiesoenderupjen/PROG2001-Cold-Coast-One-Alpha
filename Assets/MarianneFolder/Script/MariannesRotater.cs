using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class MariannesRotater : MonoBehaviour
{
    private Vector3 size;
    //public GameObject obj;
    private bool isGrowing = true;
    // Update is called once per frame

    void Update()
    {
        transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);

        if (isGrowing)
        {
            // Increase size
            transform.localScale += size * Time.deltaTime;

            // Check if almost reached max size
            if (transform.localScale.magnitude >= size.magnitude)
            {
                isGrowing = false;
            }
        }
        else
        {
            // Decrease size
            transform.localScale -= size * Time.deltaTime;

            // Check if almost reached min size
            if (transform.localScale.magnitude <= size.magnitude)
            {
                isGrowing = true;
            }
        }
        //Vector3 sizeNow = obj.transform.localScale;
        //Vector3 sizebigger = obj.transform.localScale + size;

        //if (sizeNow.magnitude < sizebigger.magnitude)
        //{
        //    obj.transform.localScale = obj.transform.localScale + size * Time.deltaTime;
        //}
        //else
        //{
        //    obj.transform.localScale = obj.transform.localScale - size * Time.deltaTime;
        //}
    }
}
