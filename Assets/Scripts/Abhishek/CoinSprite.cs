using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSprite : MonoBehaviour
{
    public LevelManager lvlManager;
    public int coinValue;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        lvlManager = FindObjectOfType<LevelManager>();
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0.7f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {
            StartCoroutine("PlaySound");
        }
    }

    private IEnumerator PlaySound()
    {
        AudioClip clip = audioSource.clip;
        audioSource.Play();
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
        lvlManager.UpdateScore(coinValue);
    }
    
}
