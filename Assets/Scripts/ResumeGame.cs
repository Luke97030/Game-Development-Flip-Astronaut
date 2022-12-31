using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeGame : MonoBehaviour
{
    public static bool isGamePasued;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePasued)
            {
                Resume();
            }
            else
            {
                Pause();
            }
               
        }
       
    }

    public void Resume()
    {
        // Resume the backgound music
        AudioSource audios = FindObjectOfType<AudioSource>();
        audios.Play();
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isGamePasued = false;
    }

    public void Pause()
    {
        // Pause the backgound music
        AudioSource audios = FindObjectOfType<AudioSource>();
        audios.Pause();
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isGamePasued = true;
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;    
        SceneManager.LoadScene("MainMenuScene");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");     
    }
}
