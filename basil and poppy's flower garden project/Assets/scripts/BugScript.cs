using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugScript : MonoBehaviour
{
    SpriteRenderer ourSpriteRenderer;

    public float Spawn;
    public float Time;
    public bool Alive;
    public float MoreBugs;
    public float STime;
    public bool SActive;
    public int sprayed;

    private void Start()
    {
        ourSpriteRenderer = GetComponent<SpriteRenderer>();
        Alive = false;
        Spawn = 50000;
    }

    

    void Update()
    {
        if (Alive == true)
        {
            if (Time > 0)
            {
                Time -= 1 * sprayed;
            }
            else if (Time == 0)
            {
                ourSpriteRenderer.color = Color.clear;

                Spawn = 500000;

                Alive = false;

                gameObject.tag = "unactive";

                transform.Translate(0, 2, 0);
            }
        }
        else if (Alive==false)
        {
            if (Spawn > 0)
            {

                Spawn -= (Mathf.Round(Random.Range(0, 10)))*MoreBugs;
                
            }
            else
            {

                Time = 500000;

                StartCoroutine(Grow());

                //ourSpriteRenderer.color = Color.white;

                Alive = true;
                
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
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {

        if (otherCollider.CompareTag("spray") == true)
        {
            SActive = true;

            STime = 5000;

            sprayed = 3;
        }

    }

        IEnumerator Grow()
    {
        
        gameObject.tag = "Bug";
        yield return new WaitForSeconds(1);
        transform.Translate(0, -2, 0);
    }
}
