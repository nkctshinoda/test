using UnityEngine;

namespace SSShooter
{
    public class StraightMovingEnemy :EnemyBase
    {
        public Vector2 direction; // �ړ�����

        // ����������
        public void Initialize(int hp, float speed, int score, Vector2 direction)
        {
            base.Initialize(hp, speed, score);
            this.direction = direction;
        }
    }
}