using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;
using UMA.PoseTools;
//using UnityEditor.Build;
using System;

public class UMAExpressionChanger : MonoBehaviour
{
    private DynamicCharacterAvatar avatar;
    private ExpressionPlayer expression;

    [Tooltip("The Time unitl the facial expression is reseted")]
    public float waitTime = 5.0f;
    private bool connected = false;
    

    [Range(0, 8)]
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

    private void OnEnable()
    {
        avatar = GetComponent<DynamicCharacterAvatar>();
        avatar.CharacterCreated.AddListener(OnCreated);
    }

    private void OnDisable()
    {
        avatar.CharacterCreated.RemoveListener(OnCreated);
    }

    public void OnCreated(UMAData data)
    {
        expression = GetComponent<ExpressionPlayer>();
        expression.enableBlinking = true;
        expression.enableSaccades = true;
        //expression.overrideMecanimNeck = true;
        //expression.overrideMecanimHead = true;


        connected = true;
    }

    private void Update()
    {
        if (connected)
        {

            

            
            float delta = 10 * Time.deltaTime;
            switch (mood)
            {
                case 0: //Neutral
                    
                    expression.leftMouthSmile_Frown = Mathf.Lerp(expression.leftMouthSmile_Frown, 0, delta);
                    expression.rightMouthSmile_Frown = Mathf.Lerp(expression.rightMouthSmile_Frown, 0, delta);
                    expression.leftUpperLipUp_Down = Mathf.Lerp(expression.leftUpperLipUp_Down, 0, delta);
                    expression.rightUpperLipUp_Down = Mathf.Lerp(expression.rightUpperLipUp_Down, 0, delta);
                    expression.leftCheekPuff_Squint = Mathf.Lerp(expression.leftCheekPuff_Squint, 0, delta);
                    expression.rightCheekPuff_Squint = Mathf.Lerp(expression.rightCheekPuff_Squint, 0f, delta);
                    expression.noseSneer = Mathf.Lerp(expression.noseSneer, 0, delta);
                    expression.leftEyeOpen_Close = Mathf.Lerp(expression.leftEyeOpen_Close, 0, delta);
                    expression.rightEyeOpen_Close = Mathf.Lerp(expression.rightEyeOpen_Close, 0, delta);
                    expression.browsIn = Mathf.Lerp(expression.browsIn, 0, delta);
                    expression.leftBrowUp_Down = Mathf.Lerp(expression.leftBrowUp_Down, 0, delta);
                    expression.rightBrowUp_Down = Mathf.Lerp(expression.rightBrowUp_Down, 0, delta);
                    expression.midBrowUp_Down = Mathf.Lerp(expression.neckUp_Down, 0, delta);
                    expression.jawOpen_Close = Mathf.Lerp(expression.jawOpen_Close, 0, delta);
                    expression.jawForward_Back = Mathf.Lerp(expression.jawForward_Back, 0, delta);
                    expression.mouthUp_Down = Mathf.Lerp(expression.mouthUp_Down, 0, delta);
                    expression.mouthNarrow_Pucker = Mathf.Lerp(expression.mouthNarrow_Pucker, 0, delta);
                    expression.leftLowerLipUp_Down = Mathf.Lerp(expression.leftLowerLipUp_Down, 0, delta);
                    expression.rightLowerLipUp_Down = Mathf.Lerp(expression.rightLowerLipUp_Down, 0, delta);
                    break;
                case 1: //Sad
                    //Expression
                    expression.leftMouthSmile_Frown = Mathf.Lerp(expression.leftMouthSmile_Frown, -.7f, delta);
                    expression.rightMouthSmile_Frown = Mathf.Lerp(expression.rightMouthSmile_Frown, -.7f, delta);
                    //Reset rest of face 
                    expression.leftUpperLipUp_Down = Mathf.Lerp(expression.leftUpperLipUp_Down, 0, delta);
                    expression.rightUpperLipUp_Down = Mathf.Lerp(expression.rightUpperLipUp_Down, 0, delta);
                    expression.leftCheekPuff_Squint = Mathf.Lerp(expression.leftCheekPuff_Squint, 0, delta);
                    expression.rightCheekPuff_Squint = Mathf.Lerp(expression.rightCheekPuff_Squint, 0f, delta);
                    expression.noseSneer = Mathf.Lerp(expression.noseSneer, 0, delta);
                    expression.leftEyeOpen_Close = Mathf.Lerp(expression.leftEyeOpen_Close, 0, delta);
                    expression.rightEyeOpen_Close = Mathf.Lerp(expression.rightEyeOpen_Close, 0, delta);
                    expression.browsIn = Mathf.Lerp(expression.browsIn, 0, delta);
                    expression.leftBrowUp_Down = Mathf.Lerp(expression.leftBrowUp_Down, 0, delta);
                    expression.rightBrowUp_Down = Mathf.Lerp(expression.rightBrowUp_Down, 0, delta);
                    expression.midBrowUp_Down = Mathf.Lerp(expression.neckUp_Down, 0, delta);
                    expression.jawOpen_Close = Mathf.Lerp(expression.jawOpen_Close, 0, delta);
                    expression.jawForward_Back = Mathf.Lerp(expression.jawForward_Back, 0, delta);
                    expression.mouthUp_Down = Mathf.Lerp(expression.mouthUp_Down, 0, delta);
                    expression.mouthNarrow_Pucker = Mathf.Lerp(expression.mouthNarrow_Pucker, 0, delta);
                    expression.leftLowerLipUp_Down = Mathf.Lerp(expression.leftLowerLipUp_Down, 0, delta);
                    expression.rightLowerLipUp_Down = Mathf.Lerp(expression.rightLowerLipUp_Down, 0, delta);
                    //switchedMood = true;
                    break;
                case 2: //Happy
                    //Expression
                    expression.leftMouthSmile_Frown = Mathf.Lerp(expression.leftMouthSmile_Frown, .7f, delta);
                    expression.rightMouthSmile_Frown = Mathf.Lerp(expression.rightMouthSmile_Frown, .7f, delta);
                    //Reset rest of face   
                    expression.leftUpperLipUp_Down = Mathf.Lerp(expression.leftUpperLipUp_Down, 0, delta);
                    expression.leftCheekPuff_Squint = Mathf.Lerp(expression.leftCheekPuff_Squint, 0, delta);
                    expression.rightCheekPuff_Squint = Mathf.Lerp(expression.rightCheekPuff_Squint, 0f, delta);
                    expression.noseSneer = Mathf.Lerp(expression.noseSneer, 0, delta);
                    expression.leftEyeOpen_Close = Mathf.Lerp(expression.leftEyeOpen_Close, 0, delta);
                    expression.rightEyeOpen_Close = Mathf.Lerp(expression.rightEyeOpen_Close, 0, delta);
                    expression.browsIn = Mathf.Lerp(expression.browsIn, 0, delta);
                    expression.leftBrowUp_Down = Mathf.Lerp(expression.leftBrowUp_Down, 0, delta);
                    expression.rightBrowUp_Down = Mathf.Lerp(expression.rightBrowUp_Down, 0, delta);
                    expression.midBrowUp_Down = Mathf.Lerp(expression.neckUp_Down, 0, delta);
                    expression.jawOpen_Close = Mathf.Lerp(expression.jawOpen_Close, 0, delta);
                    expression.jawForward_Back = Mathf.Lerp(expression.jawForward_Back, 0, delta);
                    expression.mouthUp_Down = Mathf.Lerp(expression.mouthUp_Down, 0, delta);
                    expression.mouthNarrow_Pucker = Mathf.Lerp(expression.mouthNarrow_Pucker, 0, delta);
                    expression.leftLowerLipUp_Down = Mathf.Lerp(expression.leftLowerLipUp_Down, 0, delta);
                    expression.rightLowerLipUp_Down = Mathf.Lerp(expression.rightLowerLipUp_Down, 0, delta);
                    expression.rightUpperLipUp_Down = Mathf.Lerp(expression.rightUpperLipUp_Down, 0, delta);
                    //switchedMood = true;
                    break;
                case 3: //Angry
                    //Expression
                    expression.leftMouthSmile_Frown = Mathf.Lerp(expression.leftMouthSmile_Frown, -.5f, delta);
                    expression.rightMouthSmile_Frown = Mathf.Lerp(expression.rightMouthSmile_Frown, -.5f, delta);
                    expression.leftUpperLipUp_Down = Mathf.Lerp(expression.leftUpperLipUp_Down, .5f, delta);
                    expression.leftCheekPuff_Squint = Mathf.Lerp(expression.leftCheekPuff_Squint, -.4f, delta);
                    expression.rightCheekPuff_Squint = Mathf.Lerp(expression.rightCheekPuff_Squint, -.4f, delta);
                    expression.noseSneer = Mathf.Lerp(expression.noseSneer, .1f, delta);
                    expression.leftEyeOpen_Close = Mathf.Lerp(expression.leftEyeOpen_Close, .25f, delta);
                    expression.rightEyeOpen_Close = Mathf.Lerp(expression.rightEyeOpen_Close, .25f, delta);
                    expression.browsIn = Mathf.Lerp(expression.browsIn, .25f, delta);
                    expression.leftBrowUp_Down = Mathf.Lerp(expression.leftBrowUp_Down, .7f, delta);
                    expression.rightBrowUp_Down = Mathf.Lerp(expression.rightBrowUp_Down, .7f, delta);
                    expression.midBrowUp_Down = Mathf.Lerp(expression.neckUp_Down, -.5f, delta);
                    //Reset rest of face
                    expression.jawOpen_Close = Mathf.Lerp(expression.jawOpen_Close, 0, delta);
                    expression.jawForward_Back = Mathf.Lerp(expression.jawForward_Back, 0, delta);
                    expression.mouthUp_Down = Mathf.Lerp(expression.mouthUp_Down, 0, delta);
                    expression.rightUpperLipUp_Down = Mathf.Lerp(expression.rightUpperLipUp_Down, 0, delta);
                    expression.mouthNarrow_Pucker = Mathf.Lerp(expression.mouthNarrow_Pucker, 0, delta);
                    expression.leftLowerLipUp_Down = Mathf.Lerp(expression.leftLowerLipUp_Down, 0, delta);
                    expression.rightLowerLipUp_Down = Mathf.Lerp(expression.rightLowerLipUp_Down, 0, delta);
                    //switchedMood = true;
                    break;
                case 4: //Surprised
                    //Expression
                    expression.jawOpen_Close = Mathf.Lerp(expression.jawOpen_Close, .25f, delta);
                    expression.jawForward_Back = Mathf.Lerp(expression.jawForward_Back, .25f, delta);
                    expression.mouthUp_Down = Mathf.Lerp(expression.mouthUp_Down, .2f, delta);
                    expression.mouthNarrow_Pucker = Mathf.Lerp(expression.mouthNarrow_Pucker, .2f, delta);
                    expression.noseSneer = Mathf.Lerp(expression.noseSneer, .075f, delta);
                    expression.leftEyeOpen_Close = Mathf.Lerp(expression.leftEyeOpen_Close, .5f, delta);
                    expression.rightEyeOpen_Close = Mathf.Lerp(expression.rightEyeOpen_Close, .5f, delta);
                    expression.leftBrowUp_Down = Mathf.Lerp(expression.leftBrowUp_Down, .25f, delta);
                    expression.rightBrowUp_Down = Mathf.Lerp(expression.rightBrowUp_Down, .25f, delta);
                    expression.midBrowUp_Down = Mathf.Lerp(expression.neckUp_Down,  .5f, delta);
                    //Reset rest of face
                    expression.browsIn = Mathf.Lerp(expression.browsIn, 0, delta);
                    expression.leftUpperLipUp_Down = Mathf.Lerp(expression.leftUpperLipUp_Down, 0, delta);
                    expression.rightUpperLipUp_Down = Mathf.Lerp(expression.rightUpperLipUp_Down, 0, delta);
                    expression.leftCheekPuff_Squint = Mathf.Lerp(expression.leftCheekPuff_Squint, 0, delta);
                    expression.rightCheekPuff_Squint = Mathf.Lerp(expression.rightCheekPuff_Squint, 0, delta);
                    expression.leftLowerLipUp_Down = Mathf.Lerp(expression.leftLowerLipUp_Down, 0, delta);
                    expression.rightLowerLipUp_Down = Mathf.Lerp(expression.rightLowerLipUp_Down, 0, delta);
                    //switchedMood = true;
                    break;
                case 5: //Very Sad
                    //Expression
                    expression.mouthUp_Down = Mathf.Lerp(expression.mouthUp_Down, -0.5f, delta);
                    expression.leftMouthSmile_Frown = Mathf.Lerp(expression.leftMouthSmile_Frown, -1.0f, delta);
                    expression.rightMouthSmile_Frown = Mathf.Lerp(expression.rightMouthSmile_Frown, -1.0f, delta);
                    expression.leftLowerLipUp_Down = Mathf.Lerp(expression.leftLowerLipUp_Down, 1.0f, delta);
                    expression.rightLowerLipUp_Down = Mathf.Lerp(expression.rightLowerLipUp_Down, 1.0f, delta);
                    expression.leftCheekPuff_Squint = Mathf.Lerp(expression.leftCheekPuff_Squint, -.5f, delta);
                    expression.rightCheekPuff_Squint = Mathf.Lerp(expression.rightCheekPuff_Squint, -.5f, delta);
                    expression.noseSneer = Mathf.Lerp(expression.noseSneer, .2f, delta);
                    expression.browsIn = Mathf.Lerp(expression.browsIn, 1.0f, delta);
                    expression.leftBrowUp_Down = Mathf.Lerp(expression.leftBrowUp_Down, -0.2f, delta);
                    expression.rightBrowUp_Down = Mathf.Lerp(expression.rightBrowUp_Down, -0.2f, delta);
                    expression.midBrowUp_Down = Mathf.Lerp(expression.neckUp_Down, 0.2f, delta);
                    //Reset rest of face
                    expression.leftUpperLipUp_Down = Mathf.Lerp(expression.leftUpperLipUp_Down, 0, delta);
                    expression.rightUpperLipUp_Down = Mathf.Lerp(expression.rightUpperLipUp_Down, 0, delta);
                    expression.leftEyeOpen_Close = Mathf.Lerp(expression.leftEyeOpen_Close, 0, delta);
                    expression.rightEyeOpen_Close = Mathf.Lerp(expression.rightEyeOpen_Close, 0, delta);
                    expression.jawOpen_Close = Mathf.Lerp(expression.jawOpen_Close, 0, delta);
                    expression.jawForward_Back = Mathf.Lerp(expression.jawForward_Back, 0, delta);
                    expression.mouthNarrow_Pucker = Mathf.Lerp(expression.mouthNarrow_Pucker, 0, delta);
                    //switchedMood = true;
                    break;
                case 6: //Very Happy
                    expression.mouthUp_Down = Mathf.Lerp(expression.mouthUp_Down, -.7f, delta);
                    expression.leftMouthSmile_Frown = Mathf.Lerp(expression.leftMouthSmile_Frown, 1.0f, delta);
                    expression.rightMouthSmile_Frown = Mathf.Lerp(expression.rightMouthSmile_Frown, 1.0f, delta);
                    expression.leftLowerLipUp_Down = Mathf.Lerp(expression.leftLowerLipUp_Down, -.5f, delta);
                    expression.rightLowerLipUp_Down = Mathf.Lerp(expression.rightLowerLipUp_Down, -.5f, delta);
                    expression.leftUpperLipUp_Down = Mathf.Lerp(expression.leftUpperLipUp_Down, .15f, delta);
                    expression.rightUpperLipUp_Down = Mathf.Lerp(expression.rightUpperLipUp_Down, .15f, delta);
                    expression.leftCheekPuff_Squint = Mathf.Lerp(expression.leftCheekPuff_Squint, .2f, delta);
                    expression.rightCheekPuff_Squint = Mathf.Lerp(expression.rightCheekPuff_Squint, .2f, delta);
                    expression.noseSneer = Mathf.Lerp(expression.noseSneer, .2f, delta);
                    expression.browsIn = Mathf.Lerp(expression.browsIn, 1.0f, delta);
                    expression.leftBrowUp_Down = Mathf.Lerp(expression.leftBrowUp_Down, 0.5f, delta);
                    expression.rightBrowUp_Down = Mathf.Lerp(expression.rightBrowUp_Down, 0.5f, delta);
                    expression.midBrowUp_Down = Mathf.Lerp(expression.neckUp_Down, 0.5f, delta);
                    expression.leftEyeOpen_Close = Mathf.Lerp(expression.leftEyeOpen_Close, -1.0f, delta);
                    expression.rightEyeOpen_Close = Mathf.Lerp(expression.rightEyeOpen_Close, -1.0f, delta);
                    expression.jawOpen_Close = Mathf.Lerp(expression.jawOpen_Close, 0.15f, delta);
                    //Reset rest of face
                    expression.jawForward_Back = Mathf.Lerp(expression.jawForward_Back, 0, delta);
                    expression.mouthNarrow_Pucker = Mathf.Lerp(expression.mouthNarrow_Pucker, 0, delta);
                    //switchedMood = true;
                    break;
                case 7: //Very Angry
                    //Expression
                    expression.jawOpen_Close = Mathf.Lerp(expression.jawOpen_Close, .05f, delta);
                    expression.jawForward_Back = Mathf.Lerp(expression.jawForward_Back, .5f, delta);
                    expression.mouthUp_Down = Mathf.Lerp(expression.mouthUp_Down, -.15f, delta);
                    expression.leftMouthSmile_Frown = Mathf.Lerp(expression.leftMouthSmile_Frown, -.5f, delta);
                    expression.rightMouthSmile_Frown = Mathf.Lerp(expression.rightMouthSmile_Frown, -.5f, delta);
                    expression.leftLowerLipUp_Down = Mathf.Lerp(expression.leftLowerLipUp_Down, -.8f, delta);
                    expression.rightLowerLipUp_Down = Mathf.Lerp(expression.rightLowerLipUp_Down, -.8f, delta);
                    expression.leftUpperLipUp_Down = Mathf.Lerp(expression.leftUpperLipUp_Down, .8f, delta);
                    expression.rightUpperLipUp_Down = Mathf.Lerp(expression.rightUpperLipUp_Down, .7f, delta);
                    expression.leftCheekPuff_Squint = Mathf.Lerp(expression.leftCheekPuff_Squint, -.4f, delta);
                    expression.rightCheekPuff_Squint = Mathf.Lerp(expression.rightCheekPuff_Squint, -.4f, delta);
                    expression.noseSneer = Mathf.Lerp(expression.noseSneer, .4f, delta);
                    expression.leftEyeOpen_Close = Mathf.Lerp(expression.leftEyeOpen_Close, .5f, delta);
                    expression.rightEyeOpen_Close = Mathf.Lerp(expression.rightEyeOpen_Close, .5f, delta);
                    expression.browsIn = Mathf.Lerp(expression.browsIn, 1.0f, delta);
                    expression.leftBrowUp_Down = Mathf.Lerp(expression.leftBrowUp_Down, 1.0f, delta);
                    expression.rightBrowUp_Down = Mathf.Lerp(expression.rightBrowUp_Down, 1.0f, delta);
                    expression.midBrowUp_Down = Mathf.Lerp(expression.neckUp_Down, -1.0f, delta);
                    //Reset rest of face     
                    expression.mouthNarrow_Pucker = Mathf.Lerp(expression.mouthNarrow_Pucker, 0, delta);
                    //switchedMood = true;

                    break;
                case 8: //Very Surprised 
                        //Expression
                    expression.jawOpen_Close = Mathf.Lerp(expression.jawOpen_Close, .5f, delta);
                    expression.jawForward_Back = Mathf.Lerp(expression.jawForward_Back, .25f, delta);
                    expression.mouthNarrow_Pucker = Mathf.Lerp(expression.mouthNarrow_Pucker, .5f, delta);
                    expression.leftMouthSmile_Frown = Mathf.Lerp(expression.leftMouthSmile_Frown, .1f, delta);
                    expression.rightMouthSmile_Frown = Mathf.Lerp(expression.rightMouthSmile_Frown, .1f, delta);
                    expression.leftLowerLipUp_Down = Mathf.Lerp(expression.leftLowerLipUp_Down, -.2f, delta);
                    expression.rightLowerLipUp_Down = Mathf.Lerp(expression.rightLowerLipUp_Down, -.2f, delta);
                    expression.leftUpperLipUp_Down = Mathf.Lerp(expression.leftUpperLipUp_Down, .5f, delta);
                    expression.rightUpperLipUp_Down = Mathf.Lerp(expression.rightUpperLipUp_Down, .5f, delta);
                    expression.noseSneer = Mathf.Lerp(expression.noseSneer, .5f, delta);
                    expression.leftEyeOpen_Close = Mathf.Lerp(expression.leftEyeOpen_Close, 1.0f, delta);
                    expression.rightEyeOpen_Close = Mathf.Lerp(expression.rightEyeOpen_Close, 1.0f, delta);
                    expression.browsIn = Mathf.Lerp(expression.browsIn, 1, delta);
                    expression.leftBrowUp_Down = Mathf.Lerp(expression.leftBrowUp_Down, .2f, delta);
                    expression.rightBrowUp_Down = Mathf.Lerp(expression.rightBrowUp_Down, .2f, delta);
                    expression.midBrowUp_Down = Mathf.Lerp(expression.neckUp_Down, 1, delta);
                    //Reset rest of face  
                    expression.leftCheekPuff_Squint = Mathf.Lerp(expression.leftCheekPuff_Squint, 0, delta);
                    expression.rightCheekPuff_Squint = Mathf.Lerp(expression.rightCheekPuff_Squint, 0f, delta);
                    expression.mouthUp_Down = Mathf.Lerp(expression.mouthUp_Down, 0, delta);
                    //switchedMood = true;
                    break;
                default:
                    break;
            }
            
        }
    }
}
