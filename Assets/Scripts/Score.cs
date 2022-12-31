using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    private int score = 0;

    public int increaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;
        return score;
    }
}
