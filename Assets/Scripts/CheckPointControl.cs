using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointControl : MonoBehaviour
{    
    public Sprite redflag;
    private SpriteRenderer FlagSpriteRenderer;
    public bool chkpointreached;
    // Start is called before the first frame update
    void Start()
    {
        FlagSpriteRenderer=GetComponent<SpriteRenderer> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D( Collider2D other)
    {
        if(other.tag == "Ball")
        {
            FlagSpriteRenderer.sprite=redflag;
            chkpointreached=true;
        }
    }
}
