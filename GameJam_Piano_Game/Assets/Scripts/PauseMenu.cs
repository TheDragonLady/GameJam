using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseCanvas;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseCanvas.activeSelf)
            {
                pauseCanvas.SetActive(false);
                Time.timeScale = 1f;

            }
            else if (!pauseCanvas.activeSelf)
            {
                pauseCanvas.SetActive(true);
                Time.timeScale = 0f;
            }

        }


    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Resume()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1f;
    }
}
