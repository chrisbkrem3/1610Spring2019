﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat : Dog
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello, world!"); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(100,0,0);
    }
}
