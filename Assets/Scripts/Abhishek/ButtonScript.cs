using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public Button playButton;
    public Button soundButton;
    public Sprite soundOff;
    public Sprite soundOn;
    public Button ExitButton;
    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(PlayLevel);
        soundButton.onClick.AddListener(SoundToggle);
        ExitButton.onClick.AddListener(Exit);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void PlayLevel()
    {
        SceneManager.LoadSceneAsync(1);
    }

    private void SoundToggle()
    {
        if(soundButton.image.sprite == soundOn)
        {
            soundButton.image.sprite = soundOff;
            soundButton.image.transform.rotation = Quaternion.Euler(0, 0, 90);
            AudioListener.volume = 0f;
        }
        else{
            soundButton.image.transform.rotation = Quaternion.Euler(0, 0, 0);
            soundButton.image.sprite = soundOn;
            AudioListener.volume = 1f;
        }        
    }

    private void Exit()
    {
        Application.Quit();
    }
}
