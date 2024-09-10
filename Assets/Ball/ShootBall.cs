using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootBall : MonoBehaviour
{
    public Rigidbody2D ballRigidbody; // ボールのRigidbody2Dコンポーネントをアタッチするための変数
    public LineRenderer line;
    public float maxForce = 20f; // 最大力
    public float minForce = 5f; // 最小力
    private Vector2 StartPosition; // ドラッグの開始位置
    private Vector2 EndPosition; // ドラッグの終了位置
    public float gravityScale = 1.0f;  //重力のスケール
    public AudioClip onPressSound;
    public AudioClip onReleaseSound;
    private AudioSource audioSource;

    private bool first;  //一打目（trueだったら打てる）

    void Start()
    {
        // ボールのRigidbody2Dコンポーネントを取得
        ballRigidbody = GetComponent<Rigidbody2D>();

        line = GetComponent<LineRenderer>();

        // 線の開始と終了位置をボールの位置に設定
        line.SetPosition(0,new Vector3 (-21.23f, -10.29f, 0));
        line.SetPosition(1,new Vector3 (-21.23f, -10.29f, 0));

        first = true;

        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    void Update()
    {
        if(first == true)
        {
            Aim();
        }
    }

    // ボールを飛ばすメソッド
    void ShotBall()
    {

        // 重力を一時的に無効にする
        ballRigidbody.gravityScale = 0f;

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

        // 重力を有効にする
        ballRigidbody.gravityScale = gravityScale;

        first = false;


    }

    //ボールの位置を調節するメソッド
    void Aim()
    {
        // マウスの左クリックが押されたら
        if (Input.GetMouseButtonDown(0))
        {
            // ドラッグの開始位置を取得
            StartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

<<<<<<< HEAD
            line.SetPosition(0, new Vector3(-21.9f, -11.2f, 0));
=======
            line.SetPosition(0, new Vector3(-21.23f, -10.29f, 0));
>>>>>>> main
        }
        // マウスの左クリックが離されたら
        else if (Input.GetMouseButtonUp(0))
        {
            // ドラッグの終了位置を取得
            EndPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // ボールを飛ばす
            ShotBall();
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            line.SetPosition(1, MousePosition);
        }
        else
        {
            line.SetPosition(1, new Vector3(-21.23f, -10.29f, 0));
        }

    }

    void OnMouseDown()
    {
        if (onPressSound != null)
        {
            audioSource.clip = onPressSound;
            audioSource.Play();
        }
    }

    void OnMouseUp()
    {
        if (onReleaseSound != null)
        {
            audioSource.clip = onReleaseSound;
            audioSource.Play();
        }
    }
}