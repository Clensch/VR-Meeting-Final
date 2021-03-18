using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeToEmojiScene()
    {
        SceneManager.LoadScene("01_EmojiScene");
    }
    public void ChangeToUMAScene()
    {
        SceneManager.LoadScene("01_UMAScene");
    }
    public void ChangeToUMAEmojiScene()
    {
        SceneManager.LoadScene("01_UMAEmojiScene");
    }
}
