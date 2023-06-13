using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    //stop playing music when game isPaused
    public AudioSource musicAudioSource;

    public Canvas gameCanvas;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
                gameCanvas.enabled = true;
            }
            else 
            {
                Pause();
                gameCanvas.enabled = false;
            }

            
        }
    }
    
    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

        Cursor.visible = false;
        musicAudioSource.UnPause();
        gameCanvas.enabled = true;
        
    }

    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

        musicAudioSource.Pause();
    }

    public void QuitGame ()
    {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
        SceneManager.LoadScene("MainMenu");
    }

    public void Reset()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}