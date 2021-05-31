using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    SpriteRenderer ourSpriteRenderer;
    public int time;
    public static int points;
    public Text scoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        ourSpriteRenderer = GetComponent<SpriteRenderer>();
        time = 50000;
        points = 0;
        ourSpriteRenderer.color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = points.ToString();

        if (time > 0)
        {
            time--;
        }
        else
        {

            ourSpriteRenderer.color = Color.white;
            StartCoroutine(LevelEnd());
        }
    }
    public static void AddScore(int toAdd)
    {
        points += toAdd;
    }

    IEnumerator LevelEnd()
    {


        yield return new WaitForSeconds(10);

        SceneManager.LoadScene("Menu");

    }
}
