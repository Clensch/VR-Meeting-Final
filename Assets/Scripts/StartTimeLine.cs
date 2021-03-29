using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine;

public class StartTimeLine : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayableDirector timeline;

    // Use this for initialization
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }
    void Update()
    {
        if (Input.anyKey || Input.GetAxis("Submit") > 0)
        {
            timeline.Play();
        }
    }

}
