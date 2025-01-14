using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SSShooter
{
    public class E30:EnemyMovementBase
    {
        float time; 
        public override void Move()
        {
            Vector3 moveDir = direction;
            transform.position += moveDir * speed * Time.deltaTime;
        }

        protected override void Start()
        {
            Initialize(4f, Vector2.left);
        }

        protected override void Update()
        {
            base.Update();
            time += Time.deltaTime;
            if (time >0.5) { Initialize(5f, Vector2.down); }
            if (time >1)   { Initialize(3f, Vector2.left); }
            if (time >1.5) { Initialize(5f, Vector2.up);   }
            if (time >2.5) { Initialize(3f, Vector2.left); }
            if (time >3)   { Initialize(5f, Vector2.down);
                             time = 0;                     }

        }
    }
}
