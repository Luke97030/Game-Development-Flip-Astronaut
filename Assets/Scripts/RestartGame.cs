using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Level01");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
