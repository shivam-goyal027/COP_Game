﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //for changing scene in unity

public class MainMenu1 : MonoBehaviour
{
    public void PlayGame(){
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame(){
    	Debug.Log("QUIT!");
    	Application.Quit();
    }
}
