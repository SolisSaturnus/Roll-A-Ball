﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuiteGame : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    } 
}
