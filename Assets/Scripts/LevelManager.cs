﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LaadLevel(string levelnaam)
    {
        SceneManager.LoadScene(levelnaam);
    }

    public void LaadVolgendLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StopSpel()
    {
        Application.Quit();
    }
}
