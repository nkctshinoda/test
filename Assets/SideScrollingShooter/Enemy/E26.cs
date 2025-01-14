using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SSShooter
{
    public class E26 : EnemyMovementBase
    {
        float _rotateSpeed = 100f;
        float angle;
        float roteTime;
        float sp;
        bool run = true;

        public override void Move()
        {
            if (roteTime <= 0)
            {
                roteTime = Random.Range(2.0f, 5.0f);
                run = !run;
                if (!run)
                {
                    if (sp != 1f)
                    {
                        sp = 1f;
                    }
                    else
                    {
                        sp *= roteTime;
                    }
                    Initialize(sp, Vector2.left);
                }
            }

            if (run)
            {
                roteTime -= Time.deltaTime;
                Vector3 moveDir = direction;
                transform.position += moveDir * speed * Time.deltaTime;
                angle += _rotateSpeed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 0, angle);
            }
            else
            {
                roteTime -= Time.deltaTime;
            }
        }
        // Start is called before the first frame update
        protected override void Start()
        {
            sp = 1.0f;
            roteTime = Random.Range(2.0f, 6.0f);
            Initialize(sp, Vector2.left);
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
        }
    }
}
