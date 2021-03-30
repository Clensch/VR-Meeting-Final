using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    public Image fadeImage;
    public GameObject endText;

    private bool started = false;
    private bool txtActivated = false;
    private float desiredAlpha;
    private float currentAlpha;
    private Color tmpColor;
    // Start is called before the first frame update
    void Start()
    {
        endText.SetActive(false);
        desiredAlpha = 1f;

        tmpColor = fadeImage.color;
        tmpColor.a = 0f;
        fadeImage.color = tmpColor;
        currentAlpha = tmpColor.a;
    }

    // Update is called once per frame
    void Update()
    {
        if (!started && (Input.anyKey || Input.GetAxis("Submit") > 0)) started = true;
        if ((Input.anyKey || Input.GetAxis("Submit") > 0) && txtActivated) SceneManager.LoadScene(0);
        if(started)
        {
            if (!GlobalGamaData.IsSpeaking)
            {
                currentAlpha = Mathf.MoveTowards(currentAlpha, desiredAlpha, 0.75f * Time.deltaTime);
                tmpColor.a = currentAlpha;
                fadeImage.color = tmpColor;
                if (!txtActivated && fadeImage.color.a >= 0.75f)
                {
                    txtActivated = true;
                    endText.SetActive(true);
                }
            }
        }
    }
}
