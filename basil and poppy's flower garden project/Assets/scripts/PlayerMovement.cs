using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public variable, visable in unity editor
    public float forceStrength;

    //these will be called by each button for movement
    public void MoveUp()
    {
        //get the rigidbody for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //Move in the correct direction with the set force strength
        ourRigidbody.AddForce(Vector2.up * forceStrength);
    }
    public void MoveDown()
    {
        //get the rigidbody for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //Move in the correct direction with the set force strength
        ourRigidbody.AddForce(Vector2.down * forceStrength);
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
}
