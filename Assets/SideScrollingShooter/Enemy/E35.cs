using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SSShooter
{
    public class E35 : EnemyMovementBase
    {
        public float rotationRadius = 1f; // 回転半径を適切な値に変更
        public float rotationSpeed = 1f;  // 回転速度
        private float angle = 0f;         // 現在の角度

        public override void Move()
        {
            // 角度を更新 (マイナスにすることで反時計回りに変更)
            angle -= rotationSpeed * Time.deltaTime;
            if (angle <= -180f)
            {
                angle += 180f;
            }

            // 現在の角度を基に座標を計算
            float x = Mathf.Cos(angle) * rotationRadius;
            float y = Mathf.Sin(angle) * rotationRadius;

            // オブジェクトを更新 (左方向への移動を加味)
            Vector3 moveDir = direction;
            transform.position += moveDir * speed * Time.deltaTime;

            // 回転動作を適用
            transform.position += new Vector3(x, y, 0) * Time.deltaTime;
        }

        // Start is called before the first frame update
        protected override void Start()
        {
            Initialize(1f, Vector2.left); // 初期化: 左方向への移動を設定
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
            Move();
        }
    }
}