using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace SSShooter
{
    public class E03 : EnemyMovementBase
    {
        public float changeDirectionInterval = 2f; // 方向を変える間隔
        private float timeSinceLastChange = 0f; // 最後に方向を変更した時間
        private Vector3 moveDir; // 現在の移動方向
        public override void Move()
        {
            transform.position += moveDir * speed * Time.deltaTime;
        }
        // Start is called before the first frame update
        protected override void Start()
        {
            Initialize(1f, GetRandomDirection()); // ランダムな方向で初期化
            moveDir = direction;
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();

            // 時間を計測して方向を変更
            timeSinceLastChange += Time.deltaTime;
            if (timeSinceLastChange >= changeDirectionInterval)
            {
                ChangeDirection();
            }
        }
        private void ChangeDirection()
        {
            direction = GetRandomDirection();
            moveDir = direction;
            timeSinceLastChange = 0f; // タイマーリセット
        }

        private Vector3 GetRandomDirection()
        {
            // ランダムな方向を生成
            float randomAngle = Random.Range(0f, 360f);
            return new Vector3(Mathf.Cos(randomAngle * Mathf.Deg2Rad), Mathf.Sin(randomAngle * Mathf.Deg2Rad), 0).normalized;
        }
    }
}
