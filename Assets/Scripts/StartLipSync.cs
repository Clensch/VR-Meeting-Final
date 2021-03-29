using System.Collections;
using System.Collections.Generic;
using RogoDigital.Lipsync;
using UnityEngine;

public class StartLipSync : MonoBehaviour
{
    public LipSync lipSync;
    public LipSyncData lipSyncData;
    private bool started = false;

    // Update is called once per frame
    void Update()
    {
        if(!started && (Input.anyKey || Input.GetAxis("Submit") > 0))
        {
            started = true;
            lipSync.Play(lipSyncData);
        }
    }
}
