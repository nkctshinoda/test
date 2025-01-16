using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SSShooter
{
    public class E18 : EnemyMovementBase 
    {
        
        public override void Move()
        {
            Vector3 moveDir = direction;
            transform.position += moveDir  * speed * Time.deltaTime;
            if (transform.position.y > 4)
            {
                Initialize(1f, Vector2.left + Vector2.down );
            }
            if(transform .position.y < -4)
            {
                Initialize(1f, Vector2.left + Vector2.up);
            }
        }
        // Start is called before the first frame update
        protected override void Start()
        {
            Initialize(1f, Vector2.left+Vector2 .up );
        }

        // Update is called once per frame
        protected override void  Update()
        {
            base.Update();
            
        }
    }
}
