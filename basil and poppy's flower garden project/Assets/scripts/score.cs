using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int time;
    public int points;
    public Text scoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        time = 50000;
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //scoreDisplay.text = points.ToString();

        if (time > 0)
        {
            time--;
        }
        else
        {
            StartCoroutine(LevelEnd());
        }
    }

    IEnumerator LevelEnd()
    {


        yield return new WaitForSeconds(10);

        SceneManager.LoadScene("Menu");

    }
}
