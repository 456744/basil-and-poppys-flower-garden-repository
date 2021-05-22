using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerDecay : MonoBehaviour
{
    SpriteRenderer ourSpriteRenderer;
    public float Time;
    public float WTime;
    public float Bloom;
    public bool WActive;
    public float watered;
    public float STime;
    public bool SActive;
    public int sprayed;
    public float MTime;
    public bool MActive;
    public int mulched;

    private void Start()
    {
        ourSpriteRenderer = GetComponent<SpriteRenderer>();
        Time = 10;
        Bloom = 20000000;
        WActive = false;
        watered = 1;
        sprayed = 1;
        mulched = 1;
    }


    
    private void Decay()
    {
        ourSpriteRenderer.color = Color.cyan;
        gameObject.tag = "active";
        Time = 5000;
    }


    void Update()
    {
        if (gameObject.tag == "active")
        {
            if (Time > 0)
            {
                Time = Time - 1;
            }
            else if (Time == 0)
            {
                ourSpriteRenderer.color = Color.clear;
                gameObject.tag = "unactive";
                Bloom = 10000000;
            }
        }
        else if (gameObject.tag == "unactive")
        {
            if (Bloom == 0)
            {
                Decay();
            }
            else if (Bloom > 0)
            {
                Bloom = Bloom - ((Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, 5000000)))))))))))))*watered*mulched/sprayed);
                if (Bloom < 0)
                {
                    Bloom = 0;
                }
            }
        }
        if (WActive == true)
        {
            if (WTime > 0)
            {
                WTime = WTime - 1;
            }
            else if (WTime == 0)
            {
                watered = 1;
            }
        }
        if (SActive == true)
        {
            if (STime > 0)
            {
                STime = STime - 1;
            }
            else if (STime == 0)
            {
                sprayed = 1;
            }
        }
        if (MActive == true)
        {
            if (MTime > 0)
            {
                MTime = MTime - 1;
            }
            else if (MTime == 0)
            {
                mulched = 1;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.CompareTag("water") == true)
        {
            WActive = true;

            WTime = 5000;

            watered = 3;
        }

        if (otherCollider.CompareTag("spray") == true)
        {
            SActive = true;

            STime = 5000;

            sprayed = 3;
        }

        if (otherCollider.CompareTag("mulch") == true)
        {
            MActive = true;

            MTime = 5000;

            mulched = 5;
        }

    }
}
