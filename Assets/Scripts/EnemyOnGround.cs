using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOnGround : MonoBehaviour
{
    private Animator EnemyAnimate;
    
    void Start()
    {
        EnemyAnimate=GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Ball")
        {
            EnemyAnimate.SetBool("Alert",true);            
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag=="Ball")
        {
            EnemyAnimate.SetBool("Alert",false);
        }
    }
}
