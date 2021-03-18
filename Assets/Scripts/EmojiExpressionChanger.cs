using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmojiExpressionChanger : MonoBehaviour
{
    public GameObject EmojiFace;
    public Material NeutralFace;
    public Material HappyFace;
    public Material SadFace;
    public Material AngryFace;
    public Material SurprisedFace; 
    public Material VeryHappyFace;
    public Material VerySadFace;
    public Material VeryAngryFace;
    public Material VerySurprisedFace;
    // Start is called before the first frame update
    public float waitTime = 5.0f;
    private float timer = 0.0f;
    private bool switchedMood = false;

    //[Range(0, 8)]
    //0 = Neutral, 1 = Sad, 2 = Happy, 3 = Angry, 4 = Surprised, 5 = Very Sad, 6 = Very Happy, 7 = Very Angry, 8 = Very Surprised
    public int mood;
    public void SetMood(int i)
    {
        mood = i;
    }

    public int GetMood()
    {
        return mood;
    }

    private void Update()
    {
       if(switchedMood)
        {
            timer += Time.deltaTime;
        }
       if(timer > waitTime)
        {
            switchedMood = false;
            SetMood(0);
            timer = 0.0f;
        }

       switch(mood)
        {
            case 0:
                EmojiFace.GetComponent<MeshRenderer>().material = NeutralFace;
                break;
            case 1:
                EmojiFace.GetComponent<MeshRenderer>().material = SadFace;
                switchedMood = true;
                break;
            case 2:
                EmojiFace.GetComponent<MeshRenderer>().material = HappyFace;
                switchedMood = true;
                break;
            case 3:
                EmojiFace.GetComponent<MeshRenderer>().material = AngryFace;
                switchedMood = true;
                break;
            case 4:
                EmojiFace.GetComponent<MeshRenderer>().material = SurprisedFace;
                switchedMood = true;
                break;
            case 5:
                EmojiFace.GetComponent<MeshRenderer>().material = VerySadFace;
                switchedMood = true;
                break;
            case 6:
                EmojiFace.GetComponent<MeshRenderer>().material = VeryHappyFace;
                switchedMood = true;
                break;
            case 7:
                EmojiFace.GetComponent<MeshRenderer>().material = VeryAngryFace;
                switchedMood = true;
                break;
            case 8:
                EmojiFace.GetComponent<MeshRenderer>().material = VerySurprisedFace;
                switchedMood = true;
                break;
            default:
                break;
        }
    }
}
