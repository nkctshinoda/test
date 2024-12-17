using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No02 : MonoBehaviour
{
    float Hor = 2;
    float Ver = -1;
    float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3 (Hor,Ver,0) * speed * Time.deltaTime);
    }
}
