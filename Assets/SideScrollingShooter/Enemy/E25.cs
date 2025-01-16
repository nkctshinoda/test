using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SSShooter
{
    public class E25 : EnemyMovementBase
    {
        public float rotationSpeed = 100f; // 回転速度を追加

        public override void Move()
        {
            Vector3 moveDir = direction;
            transform.position += moveDir * speed * Time.deltaTime;

            // 回転処理を追加
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
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
