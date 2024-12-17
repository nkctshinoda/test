using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No34 : MonoBehaviour
{
    float yoko;
    float tate;
    // Start is called before the first frame update
    void Start()
    {
        yoko = UnityEngine.Random.Range(-1f,1f)/20;
        tate = UnityEngine.Random.Range(-1f, 1f)/20;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(yoko, tate,0);
        if (transform.position.x > 4.5f || transform.position.x < -4.5f) yoko *= -1f;
        if(transform.position.y > 4.5f || transform.position.y < -4.5f)tate *= -1f;
        if(Input.GetMouseButtonDown(0))
        {
            yoko = UnityEngine.Random.Range(-1f, 1f) / 20;
            tate = UnityEngine.Random.Range(-1f, 1f) / 20;
        }
    }
}
