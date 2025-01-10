using UnityEngine;

namespace SSShooter
{
    public class StraightMovingEnemy :EnemyBase
    {
        public Vector2 direction; // ˆÚ“®•ûŒü

        // ‰Šú‰»ˆ—
        public void Initialize(int hp, float speed, int score, Vector2 direction)
        {
            base.Initialize(hp, speed, score);
            this.direction = direction;
        }
    }
}