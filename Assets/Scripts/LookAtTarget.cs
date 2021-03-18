using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public GameObject target;
    private Transform targetTrans;
    private void Start()
    {
        targetTrans = target.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(targetTrans);
        transform.Rotate(0, 180, 0);        
    }
}
