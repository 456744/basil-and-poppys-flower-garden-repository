using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecayOverTime : MonoBehaviour
{
    SpriteRenderer ourSpriteRenderer;

    public int Time;
    public bool active;

    private void Start()
    {
        ourSpriteRenderer = GetComponent<SpriteRenderer>();
        active = false;
        Time = 5000;
    }
    

    void Update()
    {

        if (active == true)
        {
            if (Time > 0)
            {
                ourSpriteRenderer.color = Color.white;

                Time = Time - 1;
            }
            else if (Time == 0)
            {
                ourSpriteRenderer.color = Color.clear;
            }
        }
    }
}
