using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    //string variable to use for other stuff in unity
    public string startText;
    public string updateText;

    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning(startText);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogError(updateText);
    }
}
