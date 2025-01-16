using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace SSShooter
{

    public class E07 : EnemyMovementBase   
    {
        public override void Move()
        {
            Vector3 moveDir = direction;
            // 三角波の動きを加える（Y軸に PingPong を適用）
            float waveAmplitude = 0.5f;  // 波の振幅（上下の範囲）
            float waveSpeed = 2f;        // 波の速さ
            float waveOffset = Mathf.PingPong(Time.time * waveSpeed, waveAmplitude * 2) - waveAmplitude;

            // X方向の移動に三角波の動きを加える
            moveDir.y += waveOffset;
            transform.position += moveDir * speed * Time.deltaTime;
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
