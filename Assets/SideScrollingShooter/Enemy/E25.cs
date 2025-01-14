using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SSShooter
{
    public class E25 : EnemyMovementBase
    {
        public float rotationSpeed = 100f; // ‰ñ“]‘¬“x‚ğ’Ç‰Á

        public override void Move()
        {
            Vector3 moveDir = direction;
            transform.position += moveDir * speed * Time.deltaTime;

            // ‰ñ“]ˆ—‚ğ’Ç‰Á
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
