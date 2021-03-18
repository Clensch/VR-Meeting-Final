using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSpeakBubbleDisapear : MonoBehaviour
{
    public float updateStep = 0.1f;
    public float loudness = 10f;
    public int sampleDataLength = 1024;
    private AudioSource audioSource;
    private GameObject speakeBubble;

    private float currentUpdateTime = 0f;
    private float clipLoudness;
    private float[] clipSampleData;
    private float updateTime;
    private bool timerSet = false;

    // Start is called before the first frame update
    private void Start()
    {
        speakeBubble = gameObject.transform.Find("SpeakBubble").gameObject;
        audioSource = gameObject.GetComponent<AudioSource>();
        if(!audioSource)
        {
            Debug.LogError(GetType() + ".Start: there was no audioSource set in the parent gameobject");
        }
        clipSampleData = new float[sampleDataLength];
    }

    // Update is called once per frame
    void Update()
    {
        if (audioSource.clip == null )
        {
            speakeBubble.SetActive(false);
            return;
        }
        if(timerSet)
        {
            updateTime -= Time.deltaTime;
            if(updateTime < 0)
            {
                timerSet = false;
            }
            return;
        }
        currentUpdateTime += Time.deltaTime;
        if(currentUpdateTime >= updateStep)
        {
            currentUpdateTime = 0f;
            audioSource.clip.GetData(clipSampleData, audioSource.timeSamples);
            clipLoudness = 0f;
            foreach (var sample in clipSampleData)
            {
                clipLoudness += Mathf.Abs(sample);
            }

            if(clipLoudness < loudness)
            {
                speakeBubble.SetActive(false);
            } else
            {
                speakeBubble.SetActive(true);
                updateTime = Time.deltaTime + 1.0f;
                timerSet = true;
            }
            clipLoudness /= sampleDataLength;
        }
       
    }
}
