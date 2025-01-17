using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SSShooter
{
    public class E35 : EnemyMovementBase
    {
        public float rotationRadius = 1f; // ��]���a��K�؂Ȓl�ɕύX
        public float rotationSpeed = 1f;  // ��]���x
        private float angle = 0f;         // ���݂̊p�x

        public override void Move()
        {
            // �p�x���X�V (�}�C�i�X�ɂ��邱�ƂŔ����v���ɕύX)
            angle -= rotationSpeed * Time.deltaTime;
            if (angle <= -180f)
            {
                angle += 180f;
            }

            // ���݂̊p�x����ɍ��W���v�Z
            float x = Mathf.Cos(angle) * rotationRadius;
            float y = Mathf.Sin(angle) * rotationRadius;

            // �I�u�W�F�N�g���X�V (�������ւ̈ړ�������)
            Vector3 moveDir = direction;
            transform.position += moveDir * speed * Time.deltaTime;

            // ��]�����K�p
            transform.position += new Vector3(x, y, 0) * Time.deltaTime;
        }

        // Start is called before the first frame update
        protected override void Start()
        {
            Initialize(1f, Vector2.left); // ������: �������ւ̈ړ���ݒ�
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
            Move();
        }
    }
}