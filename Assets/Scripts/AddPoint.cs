using UnityEngine;
using UnityEngine.UI;

public class AddPoint : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    public void onButtonClick()
    {
        score++;
        scoreText.text = "Score: " + score;
        Debug.Log("Button clicked");
    }
}
