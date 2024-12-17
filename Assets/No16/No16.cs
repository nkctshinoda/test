using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No16 : MonoBehaviour
{
    public float width = 3f;
    public float heidht = 2f;
    public float speed = 2f;

    private float time = 0f;

    private void Update()
    {
        time += Time.deltaTime * speed;
        float x = Mathf.Sin(time) * width;
        float y = Mathf.Sin(2 * time) * heidht / 2;
        transform.position = new Vector3(x, y, 0f);
    }
}
