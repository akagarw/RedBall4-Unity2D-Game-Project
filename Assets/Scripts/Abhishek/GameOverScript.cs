using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public Button RetryButton;
    public Button MenuButton;
    // Start is called before the first frame update
    void Start()
    {
        RetryButton.onClick.AddListener(Retry);
        MenuButton.onClick.AddListener(MainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Retry()
    {
        SceneManager.LoadSceneAsync(1);
    }

    private void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
