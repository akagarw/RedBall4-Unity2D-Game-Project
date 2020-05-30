using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager2 : MonoBehaviour
{
    public float respawnDelay;
    public PlayerControl gamePlayer;    
    public int score,lives;
    public int numberofhearts;
    public Image[] Hearts;
    public Sprite FullHeart;
    public Sprite EmptyHeart;
    public Text GUI;
    // Start is called before the first frame update
    void Start()
    {
        score=0;
        lives=3;
        numberofhearts = 3;
        GUI.text="SCORE : " + score +"/110";
        gamePlayer= FindObjectOfType<PlayerControl> ();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateScore(int t)
    {
        score+=t;
        GUI.text="SCORE : " + score + "/110";
    }

    public void UpdateLives()
    {
        lives--;
        Debug.Log(Hearts.Length);
        if(lives == 0)
        {
            SceneManager.LoadSceneAsync(3);
        }       
        for(int i=0; i<Hearts.Length; i++) 
        {
            if(i < lives)
            {
                Hearts[i].sprite = FullHeart;
            }
            else{
                Hearts[i].sprite = EmptyHeart;
            }
            if (i < numberofhearts)
            {
                Hearts[i].enabled = true;
            }
            else
            {
                Hearts[i].enabled = false;
            }
        }
    }
}
