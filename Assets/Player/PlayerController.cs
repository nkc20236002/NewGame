using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Vector3 dir;
    [SerializeField,Header("�ړ����x")] float Speed;
    [SerializeField,Header("�W�����v��")] float JumpPower;
    [SerializeField,Header("�ő�W�����v��")] int MaxJumpCount;
    int JumpCount;  //�W�����v��

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

        //�X�y�[�X�L�[�ŃW�����v
        if (Input.GetKeyDown(KeyCode.Space) && this.JumpCount < MaxJumpCount) //�n�ʂɂ��܂� < �Z��܂ŃW�����v�o����
        {
            this.rb.AddForce(transform.up * JumpPower);
            JumpCount++;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //�n�ʂɓ���������W�����v�J�E���g��0�ɂȂ�
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
