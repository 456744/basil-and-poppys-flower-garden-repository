using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public variables, visable in unity editor
    public float forceStrength;
    public float waitTime;

    //these will be called by each button for movement
    public void MoveUp()
    {
        StartCoroutine(MoveNorth());
    }

    public IEnumerator MoveNorth()
    {
        //get the rigidbody for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //Move in the correct direction with the set force strength
        ourRigidbody.AddForce(Vector2.left * (forceStrength / 2));
        yield return new WaitForSeconds(0.3F);
        ourRigidbody.AddForce(Vector2.up * forceStrength);
        yield return new WaitForSeconds(0.3F);
        ourRigidbody.AddForce(Vector2.right * (forceStrength / 2));
    }
    public void MoveDown()
    {
        StartCoroutine(MoveSouth());
    }

    public IEnumerator MoveSouth()
    {
        //get the rigidbody for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //Move in the correct direction with the set force strength
        ourRigidbody.AddForce(Vector2.left * (forceStrength / 2));
        yield return new WaitForSeconds(0.3F);
        ourRigidbody.AddForce(Vector2.down * forceStrength);
        yield return new WaitForSeconds(0.3F);
        ourRigidbody.AddForce(Vector2.right * (forceStrength / 2));
    }

    public void MoveLeft()
    {
        //get the rigidbody for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //Move in the correct direction with the set force strength
        ourRigidbody.AddForce(Vector2.left * forceStrength);
    }
    public void MoveRight()
    {
        //get the rigidbody for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //Move in the correct direction with the set force strength
        ourRigidbody.AddForce(Vector2.right * forceStrength);
    }

    public void Update()
    {
        // Get the rigidbody from our player so we can check its speed
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        // Find out from the rigidbody what our current horizontal and vertical speeds are
        float currentSpeedH = ourRigidbody.velocity.x;
        float currentSpeedV = ourRigidbody.velocity.y;

        // Get the animator that we'll be using for movement
        Animator ourAnimator = GetComponent<Animator>();

        // Tell our animator what the speeds are
        ourAnimator.SetFloat("speedH", currentSpeedH);
        ourAnimator.SetFloat("speedV", currentSpeedV);

    }
    public void Watering()
    {
        StartCoroutine(Water());
    }

    public IEnumerator Water()
    {

        // Get the animator that we'll be using for movement
        Animator ourAnimator = GetComponent<Animator>();

        ourAnimator.SetBool("watering", true);

        //change boolean to change sprite
        yield return new WaitForSeconds(waitTime);

        ourAnimator.SetBool("watering", false);

    }
    public void Spraying()
    {
        StartCoroutine(Spray());
    }

    public IEnumerator Spray()
    {

        // Get the animator that we'll be using for movement
        Animator ourAnimator = GetComponent<Animator>();

        ourAnimator.SetBool("spraying", true);

        //change boolean to change sprite
        yield return new WaitForSeconds(waitTime);

        ourAnimator.SetBool("spraying", false);

    }
}
