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
        Time = 0;
        Bloom = 5000;
    }


    
    private void Decay()
    {
        ourSpriteRenderer.color = Color.white;
        gameObject.tag = "active";
        Time = 5000000;
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
        }
        if(Bloom == 0)
        {
            Decay();
        }
        else if (Bloom > 0)
        {
            Bloom -= (Mathf.Round(Random.Range(0, 10)));
        }
    }
}
