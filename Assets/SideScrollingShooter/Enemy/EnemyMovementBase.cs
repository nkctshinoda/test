using UnityEngine;

/*
 * クラス名の衝突などを防ぐためnamespaceを使う
 * 派生クラスでoverrideするメソッドはvirtualキーワードをつけて仮想メソッドにしておく
 * privateにすべきメソッドを派生クラスからでもアクセスできるようにprotectedにしておく
 * Moveメソッドは抽象クラスとし派生クラスで実装する
 */

namespace SSShooter
{
    /// <summary>
    /// 移動コンポーネントの基底クラス
    /// </summary>
    public abstract class EnemyMovementBase : MonoBehaviour
    {
        private float speed;
        private Vector2 directon;

        protected virtual void Initialize(float spd,Vector2 dir)
        {
            speed = spd;
            directon = dir;
        }

        public abstract void Move();

        protected virtual void Update()
        {
            Move();
        }
    }
}