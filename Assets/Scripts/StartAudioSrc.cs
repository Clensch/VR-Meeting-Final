using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAudioSrc : MonoBehaviour
{
    public AudioSource speech;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (!speech.isPlaying)
            {
                speech.Play();
            }
        }
    }
}
