using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;
namespace SSShooter
{

    namespace SSShooter
    {
        using UnityEngine;

        public class E04 : EnemyMovementBase
        {
            public float changeDirectionInterval = 2f; // ������ς���Ԋu
            private float timeSinceLastChange = 0f; // �Ō�ɕ�����ύX��������
            private Vector3 moveDir; // ���݂̈ړ�����

            public override void Move()
            {
                transform.position += moveDir * speed * Time.deltaTime;
            }

            // Start is called before the first frame update
            protected override void Start()
            {
                Initialize(1f, GetRandomDirection()); // �����_���ȕ����ŏ�����
                moveDir = direction;
            }

            // Update is called once per frame
            protected override void Update()
            {
                base.Update();

                // ���Ԃ��v�����ĕ�����ύX
                timeSinceLastChange += Time.deltaTime;
                if (timeSinceLastChange >= changeDirectionInterval)
                {
                    ChangeDirection();
                }
            }

            private void ChangeDirection()
            {
                direction = GetRandomDirection();
                moveDir = direction;
                timeSinceLastChange = 0f; // �^�C�}�[���Z�b�g
            }

            private Vector3 GetRandomDirection()
            {
                // �����_���ȕ����𐶐�
                float randomAngle = Random.Range(0f, 360f);
                return new Vector3(Mathf.Cos(randomAngle * Mathf.Deg2Rad), Mathf.Sin(randomAngle * Mathf.Deg2Rad), 0).normalized;
            }
        }
    }
}
