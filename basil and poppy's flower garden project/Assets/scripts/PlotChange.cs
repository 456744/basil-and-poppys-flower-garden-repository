using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotChange : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.CompareTag("water") == true)
        {
            
        }

    }

}
