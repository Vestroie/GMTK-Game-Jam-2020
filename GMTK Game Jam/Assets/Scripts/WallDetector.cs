﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDetector : MonoBehaviour
{
    // Variables
    public bool isWall;


    // Start is called before the first frame update
    void Start()
    {
        isWall = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Wall")
        {
            isWall = true;
        }
    }
}