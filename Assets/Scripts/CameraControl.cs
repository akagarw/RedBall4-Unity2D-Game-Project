using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject Ball;
    private float xmin,ymin;
    public float xmax,ymax;
    private float temp,xnew,ynew;
    private Vector3 pos;
    public float Smoothing;
    // Start is called before the first frame update
    void Start()
    {
        xmin=transform.position.x;
        ymin=transform.position.y;          
    }

    // Update is called once per frame
    void Update()
    {        
        temp=Ball.transform.position.x;
        if(temp<xmin)
            temp=xmin;
        else if(temp>xmax)
            temp=xmax;
        xnew=temp;
        temp=Ball.transform.position.y;
        if(temp<ymin)
            temp=ymin;
        else if(temp>ymax)
            temp=ymax;
        ynew=temp;
        pos = new Vector3(xnew,ynew,transform.position.z);
        transform.position=Vector3.Lerp(transform.position,pos,Smoothing * Time.deltaTime);
    }
}
