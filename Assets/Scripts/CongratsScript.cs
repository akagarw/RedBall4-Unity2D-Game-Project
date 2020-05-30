using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CongratsScript : MonoBehaviour
{
    public Button ExitButton;
    public Button MainMenuButton;
    // Start is called before the first frame update
    void Start()
    {
        ExitButton.onClick.AddListener(Exit);
        MainMenuButton.onClick.AddListener(MainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Exit()
    {
        Application.Quit();
    }

    private void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
