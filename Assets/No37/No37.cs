using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No37 : MonoBehaviour
{
    [SerializeField] GameObject circle;

    float x;
    float y;

    Vector2 move;

    void Start()
    {
        x = 1;
        y = 1;

    }

    void Update()
    {

        if (!circle.GetComponent<SpriteRenderer>().isVisible)
        {
            if(circle.transform.position.x < 0)
            {
                x = Random.Range(0,2);
            }
            else
            {
                x = Random.Range(-1, 0); 
            }

            if(circle.transform.position.y < 0)
            {
                y = Random.Range(0, 2);
            }
            else
            {
                y = Random.Range(-1, 0);
            }


        }


        move = new Vector2(x, y) / 10;

        circle.transform.Translate(move);
    }
}
