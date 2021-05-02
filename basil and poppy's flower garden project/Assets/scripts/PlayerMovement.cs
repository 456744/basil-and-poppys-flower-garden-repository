using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public variables, visable in unity editor
    public float forceStrength;

    public float waitTime;

    public AudioClip walking;

    public AudioClip plant;

    public AudioClip spray;

    public AudioClip water;

    public GameObject plot;

    public void Start()
    {
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();
    }

    //these will be called by each button for movement
    public void MoveUp()
    {

        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        ourRigidbody.AddForce(Vector2.up * forceStrength);

        AudioSource ourAudioSource = GetComponent<AudioSource>();

        if (ourAudioSource.clip == walking && ourAudioSource.isPlaying)
        {

        }
        else
        {
            ourAudioSource.clip = walking;

            ourAudioSource.Play();
        }
    }

    public void MoveDown()
    {
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        ourRigidbody.AddForce(Vector2.down * forceStrength);

        AudioSource ourAudioSource = GetComponent<AudioSource>();

        if (ourAudioSource.clip == walking && ourAudioSource.isPlaying)
        {

        }
        else
        {
            ourAudioSource.clip = walking;

            ourAudioSource.Play();
        }
    }


    public void MoveLeft()
    {
        //get the rigidbody for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //Move in the correct direction with the set force strength
        ourRigidbody.AddForce(Vector2.left * forceStrength);

        AudioSource ourAudioSource = GetComponent<AudioSource>();

        if (ourAudioSource.clip == walking && ourAudioSource.isPlaying)
        {

        }
        else
        {
            ourAudioSource.clip = walking;

            ourAudioSource.Play();
        }
    }
    public void MoveRight()
    {
        //get the rigidbody for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //Move in the correct direction with the set force strength
        ourRigidbody.AddForce(Vector2.right * forceStrength);

        AudioSource ourAudioSource = GetComponent<AudioSource>();

        if (ourAudioSource.clip == walking && ourAudioSource.isPlaying)
        {

        }
        else
        {
            ourAudioSource.clip = walking;

            ourAudioSource.Play();
        }
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

        AudioSource ourAudioSource = GetComponent<AudioSource>();

        if (ourAudioSource.clip == water && ourAudioSource.isPlaying)
        {

        }
        else
        {
            ourAudioSource.clip = water;

            ourAudioSource.Play();
        }

        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //plot = gameObject.Find("Plot holder (" & &", " & -2 & ")");


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

        AudioSource ourAudioSource = GetComponent<AudioSource>();

        if (ourAudioSource.clip == spray && ourAudioSource.isPlaying)
        {

        }
        else
        {
            ourAudioSource.clip = spray;

            ourAudioSource.Play();
        }
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
