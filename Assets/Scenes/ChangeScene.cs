﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ToStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void ToTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene("PlayerTest");
    }


    public void ExitGame()
    {
        Application.Quit();
    }
}
