using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No31 : MonoBehaviour
{
    private Camera mainCamera;
    private Vector2 direction;
    private float speed = 3f;  // �I�u�W�F�N�g�̈ړ����x
    private float changeDirectionInterval = 1f;  // �����_���ȕ����ɕύX����Ԋu�i�b�j

    private float timeSinceDirectionChange = 0f;  // ������ύX�����o�ߎ���

    void Start()
    {
        mainCamera = Camera.main;

        // ���������������_���ɐݒ�
        SetRandomDirection();
    }

    void Update()
    {
        timeSinceDirectionChange += Time.deltaTime;

        // ���̊Ԋu�Ń����_���ȕ����ɕύX
        if (timeSinceDirectionChange >= changeDirectionInterval)
        {
            SetRandomDirection();
            timeSinceDirectionChange = 0f;  // �o�ߎ��Ԃ����Z�b�g
        }

        // �����_���ȕ����Ɉړ�
        transform.Translate(direction * speed * Time.deltaTime);

        // �J�����̃r���[�|�[�g���Ɏ��߂鏈��
        KeepObjectInsideCamera();
    }

    // �����_���ȕ�����ݒ肷��
    void SetRandomDirection()
    {
        // X��Y�̃����_���ȕ��������߂�i-1����1�͈̔́j
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }

    // �I�u�W�F�N�g���J�����̃r���[�|�[�g���Ɏ��܂�悤�ɒ���
    void KeepObjectInsideCamera()
    {
        // �I�u�W�F�N�g�̃X�N���[�����W���擾
        Vector3 viewportPosition = mainCamera.WorldToViewportPoint(transform.position);

        // X�����Ńr���[�|�[�g�O�ɏo�Ȃ��悤�ɒ���
        if (viewportPosition.x < 0f)
        {
            transform.position = mainCamera.ViewportToWorldPoint(new Vector3(0f, viewportPosition.y, viewportPosition.z));
        }
        else if (viewportPosition.x > 1f)
        {
            transform.position = mainCamera.ViewportToWorldPoint(new Vector3(1f, viewportPosition.y, viewportPosition.z));
        }

        // Y�����Ńr���[�|�[�g�O�ɏo�Ȃ��悤�ɒ���
        if (viewportPosition.y < 0f)
        {
            transform.position = mainCamera.ViewportToWorldPoint(new Vector3(viewportPosition.x, 0f, viewportPosition.z));
        }
        else if (viewportPosition.y > 1f)
        {
            transform.position = mainCamera.ViewportToWorldPoint(new Vector3(viewportPosition.x, 1f, viewportPosition.z));
        }
    }
}
