using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SSShooter {

    public class E36 :EnemyMovementBase
    {
        public float moveSpeed = 3.0f;

        // �ړ���������i�㉺���E�j
        private Vector3 targetPosition;
        private Vector3 startPosition;
        public override void Move()
        {
            Vector3 moveDir = direction;
            transform.position += moveDir* speed * Time.deltaTime;
        }
        // Start is called before the first frame update
        protected override void Start()
        {
            Initialize(1f, Vector2.left);
            startPosition = transform.position;

            // �����̖ڕW�ʒu��ݒ�
            SetRandomTarget();
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // �ڕW�ʒu�ɓ��B������V�����ڕW��ݒ�
            if (transform.position == targetPosition)
            {
                SetRandomTarget();
            }
        }
        void SetRandomTarget()
        {
            // �㉺���E�̃����_���ȕ�����I��
            int direction = Random.Range(0, 4);

            switch (direction)
            {
                case 0:
                    // ��Ɉړ�
                    targetPosition = startPosition + Vector3.up * 5.0f;
                    break;
                case 1:
                    // ���Ɉړ�
                    targetPosition = startPosition + Vector3.down * 5.0f;
                    break;
                case 2:
                    // ���Ɉړ�
                    targetPosition = startPosition + Vector3.left * 5.0f;
                    break;
                case 3:
                    // �E�Ɉړ�
                    targetPosition = startPosition + Vector3.right * 5.0f;
                    break;
            }
        }
    }
}
