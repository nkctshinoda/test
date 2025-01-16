using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

namespace SSShooter
{
    public class E02 : EnemyMovementBase
    {
        float sinY;
        float MoveRad = 0;
        float Rad;
        float Hankei = 2.5f;
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
        public override void Move()
        {
            float NewSpeed = speed * Random.Range(0.1f, 7f);
            Vector2 Movedir = direction;
            transform.Translate(Movedir * NewSpeed * Time.deltaTime);

            MoveRad++;
            Rad = Mathf.Deg2Rad * MoveRad;
            sinY = Mathf.Sin(Rad) * Hankei;
            transform.Translate(Vector2.up * sinY * NewSpeed * Time.deltaTime);
        }
    }
}

