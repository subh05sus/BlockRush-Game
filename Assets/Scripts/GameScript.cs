using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public GameObject WelcomePanel;
    public GameObject GameMain;

    void Start()
    {
        WelcomePanel.SetActive(true);
        GameMain.SetActive(false);    
    }

    public void StartButtonPressed()
    {
        WelcomePanel.SetActive(false);
        GameMain.SetActive(true);    
    }
}
