using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SSShooter
{
    public class E17 : EnemyMovementBase
    {
        public override void Move()
        {
            Vector3 moveDir = direction;
            transform.position += moveDir * speed * Time.deltaTime ;
            Vector3 pos = transform.position;
            if(pos.x > 4)
            {
                Initialize(1f, Vector2.left);
            }
            else if(pos.x < -4)
            { 
                Initialize(1f,Vector2.right);
            }

        }
        // Start is called before the first frame update
        protected override void Start()
        {
            Initialize(1f, Vector2.left);
        }

        // Update is called once per frame
        void Update()
        {
            base.Update();
        }
    }
}