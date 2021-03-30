using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMenuScenes : MonoBehaviour
{
    private bool showGreetingMenu;
    public GameObject greetingMenu;
    public GameObject mainMenu;
    // Start is called before the first frame update
    void Start()
    {
        showGreetingMenu = GlobalGamaData.ShowGreetMessage;
        if (!GlobalGamaData.ShowLineRenderer) GlobalGamaData.ShowLineRenderer = true;
        if (!showGreetingMenu) 
        {
            greetingMenu.SetActive(false);
            mainMenu.SetActive(true);
        }
        
    }
}
