﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSix : MonoBehaviour {
    LevelManager levelmanager;
    // Use this for initialization
    void Start()
    {
        levelmanager = GameObject.FindObjectOfType<LevelManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "Ball")
        {
            levelmanager.LaadLevel("Lose 6");
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
