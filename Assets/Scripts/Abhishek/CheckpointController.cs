using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    private SpriteRenderer checkpointSpriteRenderer;
    private bool checkpointReached;
    private Animator CheckpointAnimator;
    // Start is called before the first frame update
    void Start()
    {
        checkpointSpriteRenderer =  GetComponent<SpriteRenderer>();        
        checkpointReached = false;
        CheckpointAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckpointAnimator.SetBool("CheckPointReached", checkpointReached);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {
            checkpointReached = true;
        }
    }
}
