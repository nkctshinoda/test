using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No26 : MonoBehaviour
{
    public GameObject circle;
    float maxX = 8.5f;
    float maxY = 4.5f;
    float speedX = 0.05f;
    float speedY = 0.05f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //-8.5,8.5
        //-4.5,4.5
        

        if (MathF.Abs(circle.transform.position.x) >= maxX)
        {
            speedX *= -1;
        }
        if (MathF.Abs(circle.transform.position.y) >= maxY)
        {
            speedY *= -1;
        }

        circle.transform.position += new Vector3(speedX,speedY,0);
        
    }
}
