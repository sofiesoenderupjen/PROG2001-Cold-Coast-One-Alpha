using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSound;
    public AudioClip hoverSound;
    public AudioClip clickSound;

    public void HoverSound()
    {
        audioSound.PlayOneShot(hoverSound);
    }

    public void ClickSound()
    {
        audioSound.PlayOneShot(clickSound);
    }
}
