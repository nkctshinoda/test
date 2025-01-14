using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No25: MonoBehaviour
{
    public float speed = 2.0f;
    public float width = 2.0f;
    public float height = 1.0f;
    private float time;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * speed;
        float x = Mathf.Sin(time) * width;
        float y = Mathf.Sin(time * 2) * height;
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
