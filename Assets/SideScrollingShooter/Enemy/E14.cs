using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SSShooter
{
    public class E14 : EnemyMovementBase
    {public override void Move()
        {
            //Vector3 moveDir = direction;
            //transform.position += moveDir * speed * Time.deltaTime;

            //transform.Rotate(0, 0, 1);
            // オブジェクトを向いている方向に移動させる
            transform.position += transform.forward * speed * Time.deltaTime;
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
