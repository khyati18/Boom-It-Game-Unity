﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
    	SceneManager.LoadScene(4);
    }
    
    public void HomeButton()
    {
    	SceneManager.LoadScene(0);
    }
    
    public void Howtoplay()
    {
    	SceneManager.LoadScene(5);
    }
}
