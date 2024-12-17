using UnityEngine;

public class No08 : MonoBehaviour
{
    public float speed = 5f; // �ړ����x
    private Vector2 direction = new Vector2(1, 1).normalized; // �����ړ������i�E��j

    private float screenLeft, screenRight, screenTop, screenBottom;

    void Start()
    {
        // �J�����̒[�̍��W���擾
        Vector3 bottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 topRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));

        screenLeft = bottomLeft.x;
        screenRight = topRight.x;
        screenBottom = bottomLeft.y;
        screenTop = topRight.y;
    }

    void Update()
    {
        // �I�u�W�F�N�g���ړ�
        transform.Translate(direction * speed * Time.deltaTime);

        // ���݂̍��W���擾
        Vector3 position = transform.position;

        // X�����̒��˕Ԃ菈��
        if (position.x < screenLeft || position.x > screenRight)
        {
            direction.x = -direction.x; // X�����̈ړ����]
            position.x = Mathf.Clamp(position.x, screenLeft, screenRight); // ��ʊO�ɏo�Ȃ��悤�ɕ␳
        }

        // Y�����̒��˕Ԃ菈��
        if (position.y < screenBottom || position.y > screenTop)
        {
            direction.y = -direction.y; // Y�����̈ړ����]
            position.y = Mathf.Clamp(position.y, screenBottom, screenTop); // ��ʊO�ɏo�Ȃ��悤�ɕ␳
        }

        // ���f
        transform.position = position;
    }
}
