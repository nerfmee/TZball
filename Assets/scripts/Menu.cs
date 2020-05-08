using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{   
    public GameObject MenuPanel;

    public void ActivateMenu()
    {
        MenuPanel.active = true;
        Time.timeScale = 0f;
    }
    public void DisableMenu()
    {
        Time.timeScale = 1f;
        MenuPanel.active = false;
    }

}
