using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangingWithFButtons : MonoBehaviour
{
    private string currentScene;
    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
    }
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.F1) && currentScene != "01_EmojiScene") {
            SceneManager.LoadScene("01_EmojiScene");
        } 
        else if (Input.GetKeyUp(KeyCode.F2) && currentScene != "01_UMAScene")
        {
            SceneManager.LoadScene("01_UMAScene");
        } 
        else if (Input.GetKeyUp(KeyCode.F3) && currentScene != "01_UMAEmojiScene")
        {
            SceneManager.LoadScene("01_UMAEmojiScene");
        }
    }
}
