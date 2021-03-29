using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAudioSrc : MonoBehaviour
{
    public AudioSource speech;
    private bool isSpeaking = false;
    private bool isSpeechFinished = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey || Input.GetAxis("Submit") > 0)
        {
            if (!speech.isPlaying && !isSpeaking)
            {
                speech.Play();
                isSpeaking = true;
                GlobalGamaData.IsSpeaking = true;
            }
        }
        if(isSpeaking && !speech.isPlaying && !isSpeechFinished)
        {
            GlobalGamaData.IsSpeaking = false;
            isSpeechFinished = true;
        }
    }
}
