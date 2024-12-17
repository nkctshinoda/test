using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No32 : MonoBehaviour
{
    public float width = 10f;
    public float heidht = 3f;
    public float speed = 2.5f;

    private float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * speed;
        float x = Mathf.Sin(time) * width;
        float y = Mathf.Sin(3 * time) * heidht / 2;
        transform.position = new Vector3(x, y, 0f);
    }
}
