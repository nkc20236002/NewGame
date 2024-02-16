using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    public Rigidbody2D ballRigidbody; // ボールのRigidbody2Dコンポーネントをアタッチするための変数
    public LineRenderer line;
    public float maxForce = 20f; // 最大力
    public float minForce = 5f; // 最小力
    private Vector2 StartPosition; // ドラッグの開始位置
    private Vector2 EndPosition; // ドラッグの終了位置

    void Start()
    {
        // ボールのRigidbody2Dコンポーネントを取得
        ballRigidbody = GetComponent<Rigidbody2D>();

        line = GetComponent<LineRenderer>();

        // 線の開始と終了位置をボールの位置に設定
        line.SetPosition(0, transform.position);
        line.SetPosition(1, transform.position);
    }

    void Update()
    {
        // マウスの左クリックが押されたら
        if (Input.GetMouseButtonDown(0))
        {
            // ドラッグの開始位置を取得
            StartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //line.SetPosition(1, transform.position);
        }
        // マウスの左クリックが離されたら
        else if (Input.GetMouseButtonUp(0))
        {
            // ドラッグの終了位置を取得
            EndPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // ボールを飛ばす
            ShotBall();
        }

        // 線の描画更新
        line.SetPosition(0, transform.position);
        line.SetPosition(1, EndPosition);
    }

    // ボールを飛ばすメソッド
    void ShotBall()
    {
        // ドラッグした距離を計算
        float distance = Vector2.Distance(StartPosition, EndPosition);

        // ドラッグした方向を計算
        Vector2 shootDirection = EndPosition - StartPosition;
        shootDirection.Normalize();

        // 角度を計算
        float angle = Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg;

        // ボールに力を加えて飛ばす
        float force = Mathf.Clamp(distance, minForce, maxForce); // 距離に応じた力を制限
        Vector2 forceVector = Quaternion.AngleAxis(angle, Vector3.forward) * Vector2.right * force;
        ballRigidbody.AddForce(forceVector, ForceMode2D.Impulse);
    }
}