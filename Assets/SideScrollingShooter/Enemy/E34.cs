using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SSShooter
{
    public class E34 : EnemyMovementBase
    {
        float c;
        public override void Move()
        {
            Vector3 moveD = direction;
            transform.position += moveD * speed * Time.deltaTime;
        }
        // Start is called before the first frame update
        protected override void Start()
        {
            Initialize(1f, Vector2.left);
            transform.position = new Vector2(15, 0);
        }

        // Update is called once per frame
        protected override void Update()
        {
            c -= Time.deltaTime;
            if(c < 0)
            {
                c = Random.Range(0.3f, 0.5f);
                if (transform.position.y < 4 && transform.position.y > 3) Initialize(3, new Vector2(-1, Random.Range(-2, -1)));
                else if(transform.position.y > -4 && transform.position.y < -3)Initialize(3,new Vector2(-1,Random.Range(2, 1)));
                else Initialize(3, new Vector2(-1, Random.Range(-2, 3)));
            }
            base.Update();
        }
    }
}