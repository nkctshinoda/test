using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SSShooter
{
    public class E08 : EnemyMovementBase
    {
       
        private float screenTop;
        private float screenBottom;


        public override void Move()
        {
            Vector3 moveDir = direction;
            transform.position += moveDir * speed * Time.deltaTime;

            /// ��ʒ[�Œ��˕Ԃ鏈��
           
            if (transform.position.y <= screenBottom || transform.position.y >= screenTop)
            {
                direction.y = -direction.y; // Y�����𔽓]
            };
        }
        // Start is called before the first frame update
       protected override void Start()
        {
        
            Initialize(4f, Vector2.up);

           
            screenTop = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
            screenBottom = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
        }
    }
}
