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
        protected float speed;          // 移動速度
        protected Vector2 direction;    // 移動方向

        private Camera targetCamera;

        // 画面内外を定義する列挙体
        protected enum SCREEN_STATE
        {
            IN_SCREEN,
            OUT_OF_SCREEN
        }

        protected SCREEN_STATE areaState; // 画面内にいるか否かの状態
        private Vector2 screenSize;   // 画面サイズ (x: 幅, y: 高さ)

        protected Vector2 ScreenSize { get { return screenSize; } }

        /// <summary>
        /// ワールド座標系でのカメラ範囲を取得します。
        /// </summary>
        protected Rect ScreenArea
        {
            get
            {
                // カメラのビューポート座標の四隅をワールド座標に変換
                Vector3 bottomLeft = targetCamera.ViewportToWorldPoint(new Vector3(0f, 0f, 0f));
                Vector3 topRight = targetCamera.ViewportToWorldPoint(new Vector3(1f, 1f, 0f));

                // カメラ範囲のサイズを計算
                float width = topRight.x - bottomLeft.x;
                float height = topRight.y - bottomLeft.y;

                // カメラ範囲の中心座標を計算
                Vector2 center = (bottomLeft + topRight) / 2f;

                // Rect 構造体を生成して返す
                return new Rect(center.x - width / 2f, center.y - height / 2f, width, height);
            }
        }

        /// <summary>
        /// 初期化
        /// </summary>
        /// <param name="spd">速度</param>
        /// <param name="dir">方向</param>
        protected virtual void Initialize(float spd, Vector2 dir)
        {
            speed = spd;
            direction = dir.normalized; // 方向を正規化

            SwitchTargetCamera();
            UpdateAreaState();
        }

        /// <summary>
        /// 投影されるカメラをメインカメラとする
        /// </summary>
        protected virtual void SwitchTargetCamera()
        {
            targetCamera = Camera.main;
            if (targetCamera == null)
            {
                Debug.LogWarning("メインカメラが存在しません");
            }
        }

        /// <summary>
        /// 投影されるカメラを変更する
        /// </summary>
        protected virtual void SwitchTargetCamera(Camera camera)
        {
            if (camera != null)
            {
                targetCamera = camera;
            }
            else
            {
                Debug.LogWarning("指定されたカメラは存在しません");
            }
        }

        /// <summary>
        /// エリア内か否かを更新する
        /// </summary>
        private void UpdateAreaState()
        {
            // 敵のワールド座標をカメラのビューポート座標に変換
            Vector3 viewportPos = targetCamera.WorldToViewportPoint(transform.position);

            // 深度を取得
            float depth = viewportPos.z;

            // 深度を正規化
            float normalizedDepth = Mathf.InverseLerp(targetCamera.nearClipPlane, targetCamera.farClipPlane, depth);

            // 正規化された深度でビューポート座標を補正
            float x = viewportPos.x / (1f + normalizedDepth);
            float y = viewportPos.y / (1f + normalizedDepth);

            // ビューポート座標で画面内外判定
            if (x >= 0f && x <= 1f && y >= 0f && y <= 1f)
            {
                areaState = SCREEN_STATE.IN_SCREEN;
            }
            else
            {
                areaState = SCREEN_STATE.OUT_OF_SCREEN;
            }
        }

        /// <summary>
        /// 移動メソッド（抽象メソッド）
        /// </summary>
        public abstract void Move();

        protected virtual void Start()
        {
            Initialize(0f, Vector2.zero);
        }

        protected virtual void Update()
        {
            UpdateAreaState();
            Move();
        }
    }
}