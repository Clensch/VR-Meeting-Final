using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject btnOne;
    public GameObject btnTwo;
    public GameObject btnThree;
    public GameObject endText;
    public void PlaySceneOne() {
        SceneManager.LoadScene(1);
        GlobalGamaData.ShowBtnSceneOne = false;
        GlobalGamaData.ShowLineRenderer = false;
    }
    public void PlaySceneTwo()
    {
        SceneManager.LoadScene(2);
        GlobalGamaData.ShowBtnSceneTwo = false;
        GlobalGamaData.ShowLineRenderer = false;
    }
    public void PlaySceneThree()
    {
        SceneManager.LoadScene(3);
        GlobalGamaData.ShowBtnSceneThree = false;
        GlobalGamaData.ShowLineRenderer = false;
    }

    public void Start()
    {
        btnOne.SetActive(GlobalGamaData.ShowBtnSceneOne);
        btnTwo.SetActive(GlobalGamaData.ShowBtnSceneTwo);
        btnThree.SetActive(GlobalGamaData.ShowBtnSceneThree);
        if(!GlobalGamaData.ShowBtnSceneOne && !GlobalGamaData.ShowBtnSceneTwo && !GlobalGamaData.ShowBtnSceneThree)
        {
            endText.SetActive(true);
        }
    }



    public void EndProgramm()
    {
        Application.Quit();
    }
}
