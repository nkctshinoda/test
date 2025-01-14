using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SSShooter
{
    public class E37 : EnemyMovementBase
    {
        // �v���C���[�̈ʒu
        [SerializeField] Transform player;

        public override void Move()
        {

            Vector3 posP = player.position;
            Vector3 posE = transform.position;

            posE.x += (posP.x - posE.x) * 0.01f;
            posE.y += (posP.y - posE.y) * 0.01f;

            // �G�̈ʒu�ɑ��
            transform.position = posE;


        }

        protected override void Start()
        {
            Initialize(1f, Vector2.left);

        }

        protected override void Update()
        {
            base.Update();
        }
    }
}
