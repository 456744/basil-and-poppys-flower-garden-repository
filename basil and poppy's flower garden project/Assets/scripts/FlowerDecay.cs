using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public float BTime;
    public bool BActive;
    public int bugged;
    public int scoreTime;
    public bool Weed;

    private void Start()
    {
        ourSpriteRenderer = GetComponent<SpriteRenderer>();
        Time = 10;
        Bloom = 2000;
        WActive = false;
        watered = 1;
        sprayed = 1;
        mulched = 1;
        bugged = 1;
        scoreTime = 5000;
        BTime = 500000;
        Weed = false;
    }


    
    private void Decay()
    {
        if (Random.Range(0, 10) >7 )
        {
            Animator ourAnimator = GetComponent<Animator>();
            ourAnimator.SetBool("weed", true);
            Weed = true;
        }
        ourSpriteRenderer.color = Color.cyan;
        gameObject.tag = "active";
        Time = 2500;
    }


    void Update()
    {
        if (gameObject.CompareTag("active"))
        {
            if (Time > 0)
            {
                Time -= 1 * sprayed * bugged / watered / mulched;
            }
            else if (Time == 0)
            {
                ourSpriteRenderer.color = Color.clear;
                gameObject.tag = "unactive";
                Bloom = 1500;
                Animator ourAnimator = GetComponent<Animator>();
                ourAnimator.SetBool("weed", false);
                Weed = false;
            }
            if (scoreTime > 0)
            {
                scoreTime--;
            }
            else if (scoreTime == 0)
            {
                //score PlayerScore = FindObjectOfType<score>();
                if (Weed == false)
                {
                    score.AddScore(1);
                }
                else
                {
                    score.AddScore(-1);
                }
                

                scoreTime = 2400;
            }
        }
        else if (gameObject.CompareTag("unactive"))
        {
            if (Bloom == 0)
            {
                Decay();
            }
            else if (Bloom > 0)
            {
                Bloom -= Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, 5000000)))))))))))) * watered * mulched / sprayed / bugged;
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
                WTime--;
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
                STime--;
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
                MTime--;
            }
            else if (MTime == 0)
            {
                mulched = 1;
            }
        }
        if (BActive == true)
        {
            if (BTime > 0)
            {
                BTime--;
            }
            else if (BTime == 0)
            {
                bugged = 1;
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

        if (otherCollider.CompareTag("Bug") == true)
        {
            BActive = true;

            BTime = 500000;

            bugged = 5;
        }

    }
}
