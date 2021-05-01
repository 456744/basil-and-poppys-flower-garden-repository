using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    SpriteRenderer ourSpriteRenderer;

    private void Start()
    {
        ourSpriteRenderer = GetComponent<SpriteRenderer>();
        Alive = false;
        Spawn = 50;
    }

    private float Spawn;
    private float Time;
    private bool Alive;
    public float MoreBugs;

    void Update()
    {
        if (Alive == true)
        {
            if (Time > 0)
            {
                Time = Time - 1;
                Debug.LogWarning("T1");
            }
            else if (Time == 0)
            {
                ourSpriteRenderer.color = Color.clear;

                Spawn = 500;
                Debug.LogWarning("T2");
                Alive = false;
            }
        }
        else if (Alive == false)
        {
            if (Spawn > 0)
            {
                Spawn = Spawn - 1;
                Debug.LogWarning("S1");
            }
            else if (Spawn == 0)
            {
                ourSpriteRenderer.color = Color.white;

                Time = 50;
                Debug.LogWarning("S2");
                Alive = true;
            }
        }
    }
}
