﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {
        if(Input.GetMouseButtonDown(1))
        {
            SceneChange();
        }
    }


    private void SceneChange()
    {
        SceneManager.LoadScene("Restart");
    }
}
