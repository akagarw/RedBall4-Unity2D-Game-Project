using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public float RespawnDelay;
    public MovingPlank movingPlanks;
    public PlayerController Player;
    public int score = 0;
    public int numberofHearts;
    private int health;
    public Image[] Hearts;
    public Text ScoreText;
    public Sprite FullHeart;
    public Sprite EmptyHeart;
    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<PlayerController>();
        health = numberofHearts;
        ScoreText.text = "SCORE: " + score + "/75";
        movingPlanks = FindObjectOfType<MovingPlank>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Respawn()
    {
        health--;
        if (health == 0)
        {
            SceneManager.LoadSceneAsync(3);
        }
        for (int i = 0; i < Hearts.Length; i++)
        {
            if (i < health)
            {
                Hearts[i].sprite = FullHeart;
            }
            else
            {
                Hearts[i].sprite = EmptyHeart;
            }
            if (i < numberofHearts)
            {
                Hearts[i].enabled = true;
            }
            else
            {
                Hearts[i].enabled = false;
            }
        }
        if(health != 0)
        {
            Player.gameObject.SetActive(false);
            Player.transform.position = Player.RespawnPoint;
            Player.gameObject.SetActive(true);
            Player.circleCollider.enabled = true;
            Player.inputDisable = false;
            Player.PlayerDied = false;
            Player.rigidBody2D.constraints = RigidbodyConstraints2D.None;
            Player.rigidBody2D.gravityScale = 1;
            Player.audioSource.clip = Player.ThemeClip[Player.index];
            Player.index++;
            Player.rigidBody2D.mass = 1;
            Player.audioSource.Play();
            Player.audioSource.volume = 1f;
            Player.audioSource.loop = true;
            movingPlanks.transform.position = movingPlanks.oldPosition;
            movingPlanks.gameObject.GetComponent<PolygonCollider2D>().enabled = true;
            Destroy(movingPlanks.GetComponent<Rigidbody2D>());
        }
    }

    public void UpdateScore(int n)
    {
        score = score + n;
        ScoreText.text = "SCORE: " + score + "/75";
    }
}
