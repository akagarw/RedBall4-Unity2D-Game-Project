using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public bool isPaused;
    public GameObject PauseMenuUI;
    public Button RetryButton;
    public Button MainMenuButton;
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
        PauseMenuUI.SetActive(false);
        RetryButton.onClick.AddListener(Retry);
        MainMenuButton.onClick.AddListener(LoadMainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("here");
            if(isPaused)
            {
                Resume();
            }
            else{
                Pause();
            }
        }
    }

    private void Resume()
    {
        PauseMenuUI.SetActive(false);
        isPaused = false;
        Time.timeScale = 1;
    }

    private void Pause()
    {
        PauseMenuUI.SetActive(true);
        isPaused = true;
        Time.timeScale = 0;
    }

    private void Retry()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        Resume();
    }

    private void LoadMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
        Resume();
    }
}
