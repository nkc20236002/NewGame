using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class huyuu : MonoBehaviour
{
    // 初期位置
    private Vector3 startPos;

    // 浮動する高さ
    public float floatHeight = 0.5f;

    // 浮動速度
    public float floatSpeed = 1.0f;

    void Start()
    {
        // 初期位置を保存
        startPos = transform.position;
    }

    void Update()
    {
        // y軸方向の浮動を計算
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        // 新しい位置を設定
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
