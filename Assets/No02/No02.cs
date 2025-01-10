using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No02 : MonoBehaviour
{
    float MaxX = 8f;
    float MinX = -8f;
    float MaxY = 4.5f;
    float MinY = -4.5f;
    Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = new Vector2 (Random.Range(MinX,MaxX),Random.Range(MinY,MaxY));
        transform.position = pos;
    }
}
