using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SSShooter
{
    public class E30:EnemyMovementBase
    {
        float time;
        int count=0;
        public override void Move()
        {
            time += Time.deltaTime;
            Vector3 moveDir = direction;
            transform.position += moveDir * speed * Time.deltaTime;
                 if (time >   3f && count == 4) { Initialize(6f, Vector2.down); count = 0;time = 0f; }
            else if (time > 2.5f && count == 3) { Initialize(3f, Vector2.left); count++;}
            else if (time > 1.5f && count == 2) { Initialize(6f, Vector2.up  ); count++;}
            else if (time >   1f && count == 1) { Initialize(3f, Vector2.left); count++;}
            else if (time > 0.5f && count == 0) { Initialize(6f, Vector2.down); count++;}
        }

        protected override void Start()
        {
            Initialize(4f, Vector2.left);
        }

        protected override void Update()
        {
            base.Update();
        }
    }
}
