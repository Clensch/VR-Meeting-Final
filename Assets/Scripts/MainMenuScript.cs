using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlaySceneOne() {
        SceneManager.LoadScene(1);
    }
    public void PlaySceneTwo()
    {
        SceneManager.LoadScene(2);
    }
    public void PlaySceneThree()
    {
        SceneManager.LoadScene(3);
    }

}
