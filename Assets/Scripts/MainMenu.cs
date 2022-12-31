using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //public AudioSource gameSound;
    //// Start is called before the first frame update
    void Start()
    {
        //gameSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        // this setting let the game wont pause when you click play button on the main menu
        Time.timeScale = 1f;
        //gameSound.Play();
        SceneManager.LoadScene("Level01");
    }

    public void AboutGame()
    {
        SceneManager.LoadScene("AboutScene");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

}
