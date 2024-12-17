using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No05 : MonoBehaviour
{
    public GameObject Circle;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pos.x += 2f;
        }
    }
}
