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
            
            Camera camera = Camera.main;
            float border = camera.orthographicSize * 2.2f;

            if(transform.position.x >= border)
            {
                Initialize(4f, Vector2.left);
            }
            else if(transform.position.x <= -border)
            { 
                Initialize(4f,Vector2.right);
            }

        }
        // Start is called before the first frame update
        protected override void Start()
        {
            Initialize(4f, Vector2.left);
        }

        // Update is called once per frame
        void Update()
        {
            base.Update();
        }
    }
}