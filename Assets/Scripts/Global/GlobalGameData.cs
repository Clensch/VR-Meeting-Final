using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalGamaData
{
    private static bool showBtnSceneOne = true;
    private static bool showBtnSceneTwo = true;
    private static bool showBtnSceneThree = true;
    private static bool showGreetMessage = true;
    private static bool showLineRenderer = false;
    private static bool isSpeaking = false;

    public static bool ShowGreetMessage
    {
        get
        {
            return showGreetMessage;
        }
        set 
        {
            showGreetMessage = value;
        }
    }

    public static bool ShowBtnSceneOne
    {
        get
        {
            return showBtnSceneOne;
        }
        set
        {
            showBtnSceneOne = value;
        }
    }
    public static bool ShowBtnSceneTwo
    {
        get
        {
            return showBtnSceneTwo;
        }
        set
        {
            showBtnSceneTwo = value;
        }
    }
    public static bool ShowBtnSceneThree
    {
        get
        {
            return showBtnSceneThree;
        }
        set
        {
            showBtnSceneThree = value;
        }
    }
    public static bool IsSpeaking
    {
        get
        {
            return isSpeaking;
        }
        set
        {
            isSpeaking = value;
        }
    }
    public static bool ShowLineRenderer
    {
        get
        {
            return showLineRenderer;
        }
        set
        {
            showLineRenderer = value;
        }
    }
}
