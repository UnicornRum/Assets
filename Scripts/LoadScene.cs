﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
        
    }
	public void PlayGame()
    {
       
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //SceneManager.LoadScene("Level1.1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Update is called once per frame
    void Update () {
        
    }
    
}