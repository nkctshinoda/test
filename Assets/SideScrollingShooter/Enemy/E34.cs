using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SSShooter
{
    public class E34 : EnemyMovementBase
    {
        float c;
        public float MoveArea;
        public override void Move()
        {
            c -= Time.deltaTime;
            if (c < 0f)
            {
                c = Random.Range(0.3f, 0.5f);
                if (transform.position.y > MoveArea) Initialize(3f, new Vector2(-1f, Random.Range(-3f, -1f)));
                else if (transform.position.y < -MoveArea) Initialize(3f, new Vector2(-1f, Random.Range(3f, 1f)));
                else Initialize(3f, new Vector2(-1f, Random.Range(-3f, 3f)));
            }
            Vector3 moveD = direction;
            transform.position += moveD.normalized * speed * Time.deltaTime;
        }
        // Start is called before the first frame update
        protected override void Start()
        {
            Initialize(1f, Vector2.left);
            transform.position = new Vector2(15f, 0f);
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
        }
    }
}