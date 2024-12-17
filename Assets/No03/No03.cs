using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No03 : MonoBehaviour
{

    public float speed = 3f; // �ړ����x
    public float moveRange = 5f; // ���E�̈ړ��͈�

    private float startPosX; // �����ʒu��X���W
    private int direction = 1; // �ړ����� (1:�E, -1:��)

    void Start()
    {
        // �����ʒu��X���W���L�^
        startPosX = transform.position.x;
    }

    void Update()
    {
        // ���݂̈ʒu���X�V���Ȃ��獶�E�Ɉړ�
        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);

        // �ړ��͈͂𒴂���������]��
        if (transform.position.x > startPosX + moveRange)
        {
            direction = -1; // ���ɕ����]��
        }
        else if (transform.position.x < startPosX - moveRange)
        {
            direction = 1; // �E�ɕ����]��
        }
    }
}