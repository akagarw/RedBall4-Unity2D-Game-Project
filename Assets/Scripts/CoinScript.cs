using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int value;
    public LevelManager2 gameLevelM;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        gameLevelM=FindObjectOfType<LevelManager2> ();        
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D( Collider2D other )
    {
        if(other.tag == "Ball")
        {
            StartCoroutine("PlaySound");
            gameLevelM.updateScore(value);
        }
    }

    private IEnumerator PlaySound()
    {
        audioSource.Play();
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }    
}
