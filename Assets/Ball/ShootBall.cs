using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootBall : MonoBehaviour
{
    public Rigidbody2D ballRigidbody; // �{�[����Rigidbody2D�R���|�[�l���g���A�^�b�`���邽�߂̕ϐ�
    public LineRenderer line;
    public float maxForce = 20f; // �ő��
    public float minForce = 5f; // �ŏ���
    private Vector2 StartPosition; // �h���b�O�̊J�n�ʒu
    private Vector2 EndPosition; // �h���b�O�̏I���ʒu
    public float gravityScale = 1.0f;  //�d�͂̃X�P�[��
    public AudioClip onPressSound;
    public AudioClip onReleaseSound;
    private AudioSource audioSource;

    private bool first;  //��Ŗځitrue��������łĂ�j

    void Start()
    {
        // �{�[����Rigidbody2D�R���|�[�l���g���擾
        ballRigidbody = GetComponent<Rigidbody2D>();

        line = GetComponent<LineRenderer>();

        // ���̊J�n�ƏI���ʒu���{�[���̈ʒu�ɐݒ�
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

    // �{�[�����΂����\�b�h
    void ShotBall()
    {

        // �d�͂��ꎞ�I�ɖ����ɂ���
        ballRigidbody.gravityScale = 0f;

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

        // �d�͂�L���ɂ���
        ballRigidbody.gravityScale = gravityScale;

        first = false;


    }

    //�{�[���̈ʒu�𒲐߂��郁�\�b�h
    void Aim()
    {
        // �}�E�X�̍��N���b�N�������ꂽ��
        if (Input.GetMouseButtonDown(0))
        {
            // �h���b�O�̊J�n�ʒu���擾
            StartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

<<<<<<< HEAD
<<<<<<< HEAD
            line.SetPosition(0, new Vector3(-21.9f, -11.2f, 0));
=======
            line.SetPosition(0, new Vector3(-21.23f, -10.29f, 0));
>>>>>>> main
=======
            line.SetPosition(0, new Vector3(-21.23f, -10.29f, 0));
>>>>>>> e915c8e (9月10日アセット追加)
        }
        // �}�E�X�̍��N���b�N�������ꂽ��
        else if (Input.GetMouseButtonUp(0))
        {
            // �h���b�O�̏I���ʒu���擾
            EndPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // �{�[�����΂�
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