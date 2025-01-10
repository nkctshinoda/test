using UnityEngine;

/*
 * クラス名の衝突などを防ぐためnamespaceを使う
 * 派生クラスでoverrideするメソッドはvirtualキーワードをつけて仮想メソッドにしておく
 * privateにすべきメソッドを派生クラスからでもアクセスできるようにprotectedにしておく
 */

namespace SSShooter
{
    /// <summary>
    /// 敵キャラクターの基底クラス
    /// </summary>
    public class EnemyBase : MonoBehaviour
    {
        // --- 属性 ---
        public int hp;                // 体力
        public float speed;            // 移動速度
        public int score;             // 倒した時のスコア

        // --- 操作 ---
        // 初期化処理
        public virtual void Initialize(int hp, float speed, int score)
        {
            this.hp = hp;
            this.speed = speed;
            this.score = score;
        }

        // 被弾処理
        public virtual void TakeDamage(int damage)
        {
            hp -= damage;
            if (hp <= 0)
            {
                Die();
            }
        }

        // 死亡処理
        protected virtual void Die()
        {
            // スコア加算処理などをここに記述
            Destroy(gameObject);
        }
    }
}
