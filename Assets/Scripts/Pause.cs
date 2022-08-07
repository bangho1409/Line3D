using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public bool gamePaused = false;
    public GameObject pauseMenu;
    public GameObject instructor;
    public GameObject spawn;


    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (gamePaused == false)
            {
                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;
                pauseMenu.SetActive(true);
                

            }
            else
            {
                pauseMenu.SetActive(false);
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;
                
            }
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            if(instructor.activeSelf)
            {
                instructor.SetActive(false);
            }
            else
            {
                instructor.SetActive(true);
            }
        }

    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);   
        gamePaused = false;
        Time.timeScale = 1;
    }

    public void QuitMenu()
    {
        pauseMenu.SetActive(false);
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

}
