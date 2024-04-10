using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MariannesRotater : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 45, 0)*Time.deltaTime);
    }
}
