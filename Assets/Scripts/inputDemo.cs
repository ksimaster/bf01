﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputDemo: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            Debug.Log("pressed!");
        }
    }
}
