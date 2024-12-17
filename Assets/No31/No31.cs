using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No31 : MonoBehaviour
{
    private Camera mainCamera;
    private Vector2 direction;
    private float speed = 3f;  // オブジェクトの移動速度
    private float changeDirectionInterval = 1f;  // ランダムな方向に変更する間隔（秒）

    private float timeSinceDirectionChange = 0f;  // 方向を変更した経過時間

    void Start()
    {
        mainCamera = Camera.main;

        // 初期方向をランダムに設定
        SetRandomDirection();
    }

    void Update()
    {
        timeSinceDirectionChange += Time.deltaTime;

        // 一定の間隔でランダムな方向に変更
        if (timeSinceDirectionChange >= changeDirectionInterval)
        {
            SetRandomDirection();
            timeSinceDirectionChange = 0f;  // 経過時間をリセット
        }

        // ランダムな方向に移動
        transform.Translate(direction * speed * Time.deltaTime);

        // カメラのビューポート内に収める処理
        KeepObjectInsideCamera();
    }

    // ランダムな方向を設定する
    void SetRandomDirection()
    {
        // XとYのランダムな方向を決める（-1から1の範囲）
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }

    // オブジェクトがカメラのビューポート内に収まるように調整
    void KeepObjectInsideCamera()
    {
        // オブジェクトのスクリーン座標を取得
        Vector3 viewportPosition = mainCamera.WorldToViewportPoint(transform.position);

        // X方向でビューポート外に出ないように調整
        if (viewportPosition.x < 0f)
        {
            transform.position = mainCamera.ViewportToWorldPoint(new Vector3(0f, viewportPosition.y, viewportPosition.z));
        }
        else if (viewportPosition.x > 1f)
        {
            transform.position = mainCamera.ViewportToWorldPoint(new Vector3(1f, viewportPosition.y, viewportPosition.z));
        }

        // Y方向でビューポート外に出ないように調整
        if (viewportPosition.y < 0f)
        {
            transform.position = mainCamera.ViewportToWorldPoint(new Vector3(viewportPosition.x, 0f, viewportPosition.z));
        }
        else if (viewportPosition.y > 1f)
        {
            transform.position = mainCamera.ViewportToWorldPoint(new Vector3(viewportPosition.x, 1f, viewportPosition.z));
        }
    }
}
