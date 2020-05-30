using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    public float offset;
    private Vector3 playerPosition;
    public float offsetSmoothing;
    public float xmin;
    public float xmax;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = Player.transform.position;
        float temp;
        if(playerPosition.x < xmin)
        {
            temp = xmin;
        }
        else if(playerPosition.x + offset > xmax)
        {
            temp = xmax;
        }
        else{
            if(Player.transform.localScale.x > 0f)
            {
                temp = playerPosition.x + offset;
            }
            else{
                temp = playerPosition.x - offset;
            }
        }
        Vector3 NewPos = new Vector3(temp, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, NewPos, offsetSmoothing*Time.deltaTime);
    }
}
