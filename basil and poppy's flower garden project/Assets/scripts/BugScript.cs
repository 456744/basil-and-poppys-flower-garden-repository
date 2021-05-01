using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugScript : MonoBehaviour
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
    private float ran;

    void Update()
    {
        if (Alive == true)
        {
            if (Time > 0)
            {
                Time = Time - 1;
            }
            else if (Time == 0)
            {
                ourSpriteRenderer.color = Color.clear;

                Spawn = 50;

                Alive = false;
            }
        }
        else if (Alive==false)
        {
            if (Spawn > 0)
            {
                Spawn -= Mathf.Round(Random.Range(0, MoreBugs));
            }
            else if (Spawn == 0)
            {
                ourSpriteRenderer.color = Color.white;

                Time = 50;

                Alive = true;
            }
        }
    }
}
