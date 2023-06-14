using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("GameLevelOne");
        
        Time.timeScale = 1f;
        Cursor.visible = true;
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
    
}
