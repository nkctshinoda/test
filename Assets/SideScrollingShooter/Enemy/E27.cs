using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SSShooter
{
    public class E27 :EnemyMovementBase
    {
        
        public override void Move()
        {
            Vector3 moveDir = direction;
            //transform.position += moveDir * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.A))
            {
                moveDir.x -= 1;
              
            }


            if (Input.GetKey(KeyCode.D))
            {
                moveDir.x += 1;
                
            }


            if (Input.GetKey(KeyCode.W))
            {
                moveDir.y += 1;
              
            }


            if (Input.GetKey(KeyCode.S))
            {
                moveDir.y -= 1;
                
            }

            transform.Translate ( moveDir * speed * Time.deltaTime);
        }
        // Start is called before the first frame update
        protected override void  Start()
        {
           // Initialize(1f,Vector2.left);
            speed = 2;
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
        }
    }
}