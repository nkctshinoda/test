using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No07 : MonoBehaviour
{
    public float speed = 2f;               
    public float radius = 3f;              
    public bool moveInCircle = true;       

    private Vector3 startPosition;         
    private float angle = 0f;              
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        if (moveInCircle)
        {
            
            angle += speed * Time.deltaTime;  
            float x = Mathf.Cos(angle) * radius;
            float y = Mathf.Sin(angle) * radius;

            transform.position = startPosition + new Vector3(x, y, 0f);
        }
        else
        {
            
            transform.position += Vector3.right * speed * Time.deltaTime;

         
            if (transform.position.x > startPosition.x + 10f) 
            {
                transform.position = startPosition;
            }
        }
    }
}
