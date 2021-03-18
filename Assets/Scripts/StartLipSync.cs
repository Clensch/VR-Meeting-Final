using System.Collections;
using System.Collections.Generic;
using RogoDigital.Lipsync;
using UnityEngine;

public class StartLipSync : MonoBehaviour
{
    public LipSync lipSync;
    public LipSyncData lipSyncData;
    private bool spacePressed = false;

    // Update is called once per frame
    void Update()
    {
        if(!spacePressed && Input.GetKeyDown("space"))
        {
            spacePressed = true;
            lipSync.Play(lipSyncData);
        }
    }
}
