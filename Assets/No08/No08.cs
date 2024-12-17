using UnityEngine;

public class No08 : MonoBehaviour
{
    public float speed = 5f; // 移動速度
    private Vector2 direction = new Vector2(1, 1).normalized; // 初期移動方向（右上）

    private float screenLeft, screenRight, screenTop, screenBottom;

    void Start()
    {
        // カメラの端の座標を取得
        Vector3 bottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 topRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));

        screenLeft = bottomLeft.x;
        screenRight = topRight.x;
        screenBottom = bottomLeft.y;
        screenTop = topRight.y;
    }

    void Update()
    {
        // オブジェクトを移動
        transform.Translate(direction * speed * Time.deltaTime);

        // 現在の座標を取得
        Vector3 position = transform.position;

        // X方向の跳ね返り処理
        if (position.x < screenLeft || position.x > screenRight)
        {
            direction.x = -direction.x; // X方向の移動反転
            position.x = Mathf.Clamp(position.x, screenLeft, screenRight); // 画面外に出ないように補正
        }

        // Y方向の跳ね返り処理
        if (position.y < screenBottom || position.y > screenTop)
        {
            direction.y = -direction.y; // Y方向の移動反転
            position.y = Mathf.Clamp(position.y, screenBottom, screenTop); // 画面外に出ないように補正
        }

        // 反映
        transform.position = position;
    }
}
