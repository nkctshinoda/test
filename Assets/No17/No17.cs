using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No17 : MonoBehaviour
{
    Vector2 pos;
    bool flg;
    void Start()
    {

    }

    void Update()
    {
        if(pos.x <= -11)flg = true;
        if(pos.x >= 11)flg = false;
        if(!flg)
        {
            pos.x -= 1 * Time.deltaTime*2;
            pos.y -= 0.41f * Time.deltaTime*2;
        }
        else 
        {
            pos.x += 1 * Time.deltaTime*2;
            pos.y += 0.41f * Time.deltaTime*2;
        }
        transform.position = pos;
    }
}
