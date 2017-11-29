using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour {


    public static int score;

    Text text;
    public int currentscore;

    void Start()
    {
        //sets the score at the start of the scene to 0
        text = GetComponent<Text>();
        score = 0;
    }
    void Update()
    {
        //Updates the score on the UIText
        if (score < 0)
            score = 0;

        text.text = "" + score;
        //Updates score to currentscore
        currentscore = score;
    }

    public static void AddPoints (int pointsToAdd)
    {
        //adds amount of points when keys are picked up
        score += pointsToAdd;
    }

    public static void Reset()
    {
        //resets score to 0
        score = 0;
    }
    public void CurrentScore()
    {
        //Current score
        score = currentscore;
    }
}
