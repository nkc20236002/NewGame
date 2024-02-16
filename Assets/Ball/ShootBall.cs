using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    public Rigidbody2D ballRigidbody; // �{�[����Rigidbody2D�R���|�[�l���g���A�^�b�`���邽�߂̕ϐ�
    public LineRenderer line;
    public float maxForce = 20f; // �ő��
    public float minForce = 5f; // �ŏ���
    private Vector2 StartPosition; // �h���b�O�̊J�n�ʒu
    private Vector2 EndPosition; // �h���b�O�̏I���ʒu

    void Start()
    {
        // �{�[����Rigidbody2D�R���|�[�l���g���擾
        ballRigidbody = GetComponent<Rigidbody2D>();

        line = GetComponent<LineRenderer>();

        // ���̊J�n�ƏI���ʒu���{�[���̈ʒu�ɐݒ�
        line.SetPosition(0, transform.position);
        line.SetPosition(1, transform.position);
    }

    void Update()
    {
        // �}�E�X�̍��N���b�N�������ꂽ��
        if (Input.GetMouseButtonDown(0))
        {
            // �h���b�O�̊J�n�ʒu���擾
            StartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //line.SetPosition(1, transform.position);
        }
        // �}�E�X�̍��N���b�N�������ꂽ��
        else if (Input.GetMouseButtonUp(0))
        {
            // �h���b�O�̏I���ʒu���擾
            EndPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // �{�[�����΂�
            ShotBall();
        }

        // ���̕`��X�V
        line.SetPosition(0, transform.position);
        line.SetPosition(1, EndPosition);
    }

    // �{�[�����΂����\�b�h
    void ShotBall()
    {
        // �h���b�O�����������v�Z
        float distance = Vector2.Distance(StartPosition, EndPosition);

        // �h���b�O�����������v�Z
        Vector2 shootDirection = EndPosition - StartPosition;
        shootDirection.Normalize();

        // �p�x���v�Z
        float angle = Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg;

        // �{�[���ɗ͂������Ĕ�΂�
        float force = Mathf.Clamp(distance, minForce, maxForce); // �����ɉ������͂𐧌�
        Vector2 forceVector = Quaternion.AngleAxis(angle, Vector3.forward) * Vector2.right * force;
        ballRigidbody.AddForce(forceVector, ForceMode2D.Impulse);
    }
}