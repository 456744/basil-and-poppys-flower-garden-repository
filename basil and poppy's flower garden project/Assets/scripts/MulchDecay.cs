using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulchDecay : MonoBehaviour
{
    SpriteRenderer ourSpriteRenderer;

    public int Time;
    public bool active;

    private void Start()
    {
        ourSpriteRenderer = GetComponent<SpriteRenderer>();
        active = false;
    }


    void Update()
    {

        if (active == true)
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

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.CompareTag("mulch") == true)
        {
            active = true;

            Time = 5000;

            ourSpriteRenderer.color = Color.white;
        }

    }
}

