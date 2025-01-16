using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SSShooter {

    public class E36 :EnemyMovementBase
    {
        public float moveSpeed = 3.0f;

        // 移動する方向（上下左右）
        private Vector3 targetPosition;
        private Vector3 startPosition;
        public override void Move()
        {
            Vector3 moveDir = direction;
            transform.position += moveDir* speed * Time.deltaTime;
        }
        // Start is called before the first frame update
        protected override void Start()
        {
            Initialize(1f, Vector2.left);
            startPosition = transform.position;

            // 初期の目標位置を設定
            SetRandomTarget();
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // 目標位置に到達したら新しい目標を設定
            if (transform.position == targetPosition)
            {
                SetRandomTarget();
            }
        }
        void SetRandomTarget()
        {
            // 上下左右のランダムな方向を選択
            int direction = Random.Range(0, 4);

            switch (direction)
            {
                case 0:
                    // 上に移動
                    targetPosition = startPosition + Vector3.up * 5.0f;
                    break;
                case 1:
                    // 下に移動
                    targetPosition = startPosition + Vector3.down * 5.0f;
                    break;
                case 2:
                    // 左に移動
                    targetPosition = startPosition + Vector3.left * 5.0f;
                    break;
                case 3:
                    // 右に移動
                    targetPosition = startPosition + Vector3.right * 5.0f;
                    break;
            }
        }
    }
}
