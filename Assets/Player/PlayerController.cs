using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Vector3 dir;
    [SerializeField,Header("移動速度")] float Speed;
    [SerializeField,Header("ジャンプ力")] float JumpPower;
    [SerializeField,Header("最大ジャンプ数")] int MaxJumpCount;
    int JumpCount;  //ジャンプ回数

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        transform.position += dir.normalized * Speed * Time.deltaTime;

        float speedx = Mathf.Abs(dir.x);

        //スペースキーでジャンプ
        if (Input.GetKeyDown(KeyCode.Space) && this.JumpCount < MaxJumpCount) //地面につくまで < 〇回までジャンプ出来る
        {
            this.rb.AddForce(transform.up * JumpPower);
            JumpCount++;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //地面に当たったらジャンプカウントが0になる
        if (collision.gameObject.CompareTag("floor"))
        {
            JumpCount = 0;
        }

        if (collision.gameObject.CompareTag("Hari"))
        {
            SceneManager.LoadScene("Stage1");
        }
    }
}
