using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No04 : MonoBehaviour
{
    // 回転速度 (度/秒)
    public float rotationSpeed = 100f;

    void Update()
    {
        // Z軸を中心に回転させる
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}