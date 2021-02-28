using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                GameResume();
            }
            else
            {
                GamePause();
            }
        }
    }

    public void GameResume()
    {
        pauseMenuUI.SetActive(false);
        Data.Instance.speed = Data.Instance.pausedSpeed;
        GameIsPaused = false;
    }

    void GamePause()
    {
        pauseMenuUI.SetActive(true);
        Data.Instance.pausedSpeed = Data.Instance.speed;
        Data.Instance.speed = 0f;
        GameIsPaused = true;
    }
}
