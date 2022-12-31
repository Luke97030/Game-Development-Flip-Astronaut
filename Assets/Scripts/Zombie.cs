using UnityEngine;
using Random = UnityEngine.Random;

public class Zombie : MonoBehaviour
{
    private float speed;

    private bool flagPassedNeg9 = false;
    private int currentScore = 0;
    private int currentLevel = 0;

    public Score scoreScript;
    public Level levelScript;

    // Start is called before the first frame update
    void Start()
    {
        // this will make sure the random numbers are generated are same each time
        // E.g: 3.66, 2.933, 4.65... are the deterministic numbers every time
        Random.InitState(0);
        // when you put float value into the Range function, the min and max value will be includsive
        // when you put int value into the Range function, the min and max value will be exclusive 
        speed = Random.Range(2.0f, 6.0f);
        Debug.Log(speed);
    }

    // Update is called once per frame
    void Update()
    { 
        Vector2 position = transform.position;
        position.x -= speed * Time.deltaTime;

        if (position.x < -9.0f && flagPassedNeg9 == false)
        {
            // set the flag to true, so the socre wont be added up for each frame
            flagPassedNeg9 = true;
            currentScore = scoreScript.increaseScore();
            //Debug.Log(currentScore);
            if (currentScore == 20)
            {
                currentLevel = levelScript.increaseLevel(currentScore);
                if (currentLevel == 2)
                    speed = Random.Range(7.0f, 9.0f);
            }
            else if (currentScore >= 40 && currentScore < 60)
            {

                currentLevel = levelScript.increaseLevel(currentScore);
                // set the speed depends on level 
                if (currentLevel == 3)
                    speed = Random.Range(10.0f, 12.0f);
            }
            else if (currentScore >= 60)
            {

                currentLevel = levelScript.increaseLevel(currentScore);
                // set the speed depends on level 
                if (currentLevel == 4)
                    speed = Random.Range(13.0f, 15.0f);
            }
        }

        if (position.x < -10.0f)
        {
            // reset the flag
            flagPassedNeg9 = false;
            position.x = 10.0f;
            position.y = Random.Range(-1.0f, -4.5f);
        }

        transform.position = position;        
    }

}
