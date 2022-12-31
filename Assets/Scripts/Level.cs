using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    // Start is called before the first frame update
    public Text LevelText;
    private int level = 1;
    private List<bool> scoreCheckList = new List<bool>() { false, false, false };

    public int increaseLevel(int score)
    {
        if (score == 20 || score == 40 || score == 60)
        {
            level++;
            LevelText.text = "Level: " + level;
        }
        return level;
    }
}
