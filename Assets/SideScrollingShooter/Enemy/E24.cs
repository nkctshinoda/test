using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SSShooter
{
    public class E24 : EnemyMovementBase 
    {

        public override void Move()
        {
            Vector3 moveDir = direction;
            transform.position += moveDir  * speed * Time.deltaTime;
        }

        // Start is called before the first frame update
       protected override void Start()
        { 
            Vector3 startPosition = new Vector3(Screen.width + 50, Screen.height / 2, 0);
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(startPosition);
            worldPosition.z = 0; 
            transform.position = worldPosition;
            Initialize(1f, Vector2.left);
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
            Move();
        }
    }
}
