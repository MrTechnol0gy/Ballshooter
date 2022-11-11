﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Sam Robichaud 
// NSCC Truro 2022

public class LevelManager : MonoBehaviour
{
    
    public int nextScene;
    private int currentScene;
    public int levelSelect;


    public void LoadNextlevel()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextScene <= 5)
        {
            SceneManager.LoadScene(nextScene);
        }

        else if (nextScene >= 6)
        {
            Debug.Log("All levels complete!");
        }
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene(levelSelect);
    }

    public void QuitGame()
    {
        Application.Quit();        
    }
}



