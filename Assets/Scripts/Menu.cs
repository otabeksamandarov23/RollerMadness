﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
     public void PlayGame(){
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

     public void MainMenuGame(){
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame(){
        Debug.Log ("Exit!");
        Application.Quit();
    }
}
