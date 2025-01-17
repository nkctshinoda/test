﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SSShooter
{
    public class E31 : EnemyMovementBase
    {
        public float verticalSpeed = 2f;
        private float verticalDirection = 1f;

        public override void Move()
        {
            Vector3 moveDir = direction;
            transform.position += moveDir * speed * Time.deltaTime;

            float verticalMovement = verticalDirection * verticalSpeed * Time.deltaTime;
            float horizontalMovement = direction.x * speed * Time.deltaTime;

            transform.position += new Vector3(horizontalMovement, verticalMovement, 0);

            if (transform.position.y > 4f)
            {
                verticalDirection = -1f;
            }
            else if (transform.position.y < -4f)
            {
                verticalDirection = 1f;
            }
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
