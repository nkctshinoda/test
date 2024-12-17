using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No29 : MonoBehaviour
{

    float StateTime = 0f;


    void Start()
    {
        
    }

    void Update()
    {
        StateTime += Time.deltaTime;

        if (StateTime >= 1.0f)
        {
            float Ran_pos_y = Random.Range(-5.0f, 5.0f);
            float Ran_pos_x = Random.Range(-9.0f, 9.0f);

            Vector2 nextPos = new Vector2(Ran_pos_x, Ran_pos_y);

            this.transform.position = nextPos;
            StateTime = 0f;
        }
    }
}
