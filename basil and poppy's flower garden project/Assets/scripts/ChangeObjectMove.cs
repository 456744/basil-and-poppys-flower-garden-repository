using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObjectMove : MonoBehaviour
{
    // Start is called before the first frame update
    public void Move()
    {
        
        StartCoroutine(Activate());
    }
        
    IEnumerator Activate()
    {
        transform.Translate(0, -2, 0);
        yield return new WaitForSeconds(1);
        transform.Translate(0, 2, 0);
    }

}
