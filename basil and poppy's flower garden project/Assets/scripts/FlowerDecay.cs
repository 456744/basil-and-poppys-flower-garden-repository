﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerDecay : MonoBehaviour
{
    SpriteRenderer ourSpriteRenderer;

    private void Start()
    {
        ourSpriteRenderer = GetComponent<SpriteRenderer>();
    }


    private float Time;
    private void Decay()
    {
        ourSpriteRenderer.color = Color.white;

        Time = 500000;
    }


    void Update()
    {
        if (Time > 0)
        {
            Time = Time - 1;
        }
        else if (Time == 0)
        {
            ourSpriteRenderer.color = Color.clear;
        }
    }
}
