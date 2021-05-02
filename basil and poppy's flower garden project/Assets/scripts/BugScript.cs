using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugScript : MonoBehaviour
{
    SpriteRenderer ourSpriteRenderer;

    private float Spawn;
    private float Time;
    private bool Alive;
    public float MoreBugs;
    public float Sprayed;

    private void Start()
    {
        ourSpriteRenderer = GetComponent<SpriteRenderer>();
        Alive = false;
        Spawn = 500000;
    }

    

    void Update()
    {
        if (Alive == true)
        {
            if (Time > 0)
            {
                Time -= Sprayed;
            }
            else if (Time == 0)
            {
                ourSpriteRenderer.color = Color.clear;

                Spawn = 500000;

                Alive = false;
            }
        }
        else if (Alive==false)
        {
            if (Spawn > 0)
            {
                Spawn -= (Mathf.Round(Random.Range(0, 10)))*MoreBugs;
            }
            else if (Spawn == 0)
            {
                ourSpriteRenderer.color = Color.white;

                Time = 500000;

                Alive = true;
            }
        }
    }
}
