using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public Image fade;
    public GameObject msg;
    public float fadeTimer = 5f;
    public float timeUntilFadeStart = 5f;
    private bool started = false;
    // Start is called before the first frame update
    void Start()
    {
        fade.canvasRenderer.SetAlpha(1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!started && (Input.anyKey || Input.GetAxis("Submit") > 0)) {
            started = true;
                msg.SetActive(false);
                };
        if(started)
        {
            timeUntilFadeStart -= Time.deltaTime;
            if (timeUntilFadeStart <= 0)
            {
                fade.CrossFadeAlpha(0f, fadeTimer, true);
                if (fade.canvasRenderer.GetAlpha() < 0.2f)
                {
                    this.gameObject.SetActive(false);
                }
            }
        }
    }
}
