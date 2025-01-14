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
    /// 敵の移動コンポーネントの基底クラス
    /// </summary>
    public abstract class EnemyMovementBase : MonoBehaviour
    {
        protected float speed;          //速度
        protected Vector2 direction;    //方向

        /// <summary>
        /// 初期化メソッド
        /// </summary>
        /// <param name="spd">速度</param>
        /// <param name="dir">方向</param>

        protected virtual void Initialize(float spd, Vector2 dir)
        {
            speed = spd;
            direction = dir;
        }

        /// <summary>
        /// 移動メソッド（抽象メソッド）
        /// </summary>
        public abstract void Move();

        /// <summary>
        /// オーバーライド可能なStart
        /// </summary>
        protected virtual void Start()
        {
            Initialize(0f, Vector2.zero);
        }

        /// <summary>
        /// オーバーライド可能なUpdate
        /// </summary>
        protected virtual void Update()
        {
            Move();
        }
    }
}