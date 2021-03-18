using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionMenuSpawner : MonoBehaviour
{
    public GameObject radialMenuLightEmotions;
    public GameObject radialMenuStrongEmotions;
    // Start is called before the first frame update
    void Start()
    {
        radialMenuLightEmotions.SetActive(false);
        radialMenuStrongEmotions.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift) && radialMenuLightEmotions.activeSelf)
        {
            radialMenuLightEmotions.SetActive(false);
            radialMenuStrongEmotions.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            radialMenuLightEmotions.SetActive(true);
            radialMenuStrongEmotions.SetActive(false);
        }
        if(Input.GetKeyUp(KeyCode.LeftControl))
        {
            radialMenuLightEmotions.SetActive(false);
            radialMenuStrongEmotions.SetActive(false);
        }
    }
}
