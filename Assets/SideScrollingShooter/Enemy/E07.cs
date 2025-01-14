using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace SSShooter
{

    public class E07 : EnemyMovementBase   
    {
        public override void Move()
        {
            Vector3 moveDir = direction;
            // �O�p�g�̓�����������iY���� PingPong ��K�p�j
            float waveAmplitude = 0.5f;  // �g�̐U���i�㉺�͈̔́j
            float waveSpeed = 2f;        // �g�̑���
            float waveOffset = Mathf.PingPong(Time.time * waveSpeed, waveAmplitude * 2) - waveAmplitude;

            // X�����̈ړ��ɎO�p�g�̓�����������
            moveDir.y += waveOffset;
            transform.position += moveDir * speed * Time.deltaTime;
        }
        // Start is called before the first frame update
        protected override void Start()
        {
            Initialize(1f, Vector2.left);
        }

        // Update is called once per frame
       protected override void Update()
        {
            base.Update();
        }
    }
}
