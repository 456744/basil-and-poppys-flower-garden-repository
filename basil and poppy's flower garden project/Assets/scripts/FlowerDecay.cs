using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerDecay : MonoBehaviour
{
    SpriteRenderer ourSpriteRenderer;
    private float Time;
    public float Bloom;
    private void Start()
    {
        ourSpriteRenderer = GetComponent<SpriteRenderer>();
        Time = 10;
        Bloom = 1000;
    }


    
    private void Decay()
    {
        ourSpriteRenderer.color = Color.white;
        gameObject.tag = "active";
        Time = 500000;
        Bloom = -1;
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
            gameObject.tag = "unactive";
            Bloom = 5000;
        }
        if(Bloom == 0)
        {
            Decay();
        }
        else if (Bloom > 0)
        {
            Bloom -= (Mathf.Round(Random.Range(0, 10)));
            if(Bloom < 0)
            {
                Bloom = 0;
            }
        }
    }
}
