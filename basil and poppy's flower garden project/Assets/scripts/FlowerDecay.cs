using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerDecay : MonoBehaviour
{
    SpriteRenderer ourSpriteRenderer;
    public float Time;
    public float Bloom;
    private void Start()
    {
        ourSpriteRenderer = GetComponent<SpriteRenderer>();
        Time = 10;
        Bloom = 20000000;
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
                Bloom = 500000;
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
                Bloom = Bloom - (Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, 5000000)))))))))))));
                Debug.LogWarning(Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, Random.Range(0, 5000000)))))))))))));
                if (Bloom < 0)
                {
                    Bloom = 0;
                }
            }
        }
    }
}
