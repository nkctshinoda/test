using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No10 : MonoBehaviour
{
    public float radius = 5.0f;
    public float speed = 1.0f;
    private Vector2 center;
    private float angle;
    // Start is called before the first frame update
    void Start()
    {
        center = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        {
            angle += speed * Time.deltaTime;
            float x = Mathf.Cos(angle) * radius;
            float y = Mathf.Sin(angle) * radius;
            transform.position = new Vector2(center.x + x, center.y + y);
        }
    }
}
