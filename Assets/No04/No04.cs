using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No04 : MonoBehaviour
{
    // ��]���x (�x/�b)
    public float rotationSpeed = 100f;

    void Update()
    {
        // Z���𒆐S�ɉ�]������
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}