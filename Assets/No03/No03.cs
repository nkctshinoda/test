using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No03 : MonoBehaviour
{

    public float speed = 3f; // 移動速度
    public float moveRange = 5f; // 左右の移動範囲

    private float startPosX; // 初期位置のX座標
    private int direction = 1; // 移動方向 (1:右, -1:左)

    void Start()
    {
        // 初期位置のX座標を記録
        startPosX = transform.position.x;
    }

    void Update()
    {
        // 現在の位置を更新しながら左右に移動
        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);

        // 移動範囲を超えたら方向転換
        if (transform.position.x > startPosX + moveRange)
        {
            direction = -1; // 左に方向転換
        }
        else if (transform.position.x < startPosX - moveRange)
        {
            direction = 1; // 右に方向転換
        }
    }
}