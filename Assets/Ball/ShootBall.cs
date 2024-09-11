using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootBall : MonoBehaviour
{
    public Rigidbody2D ballRigidbody; // ƒ{[ƒ‹‚ÌRigidbody2DƒRƒ“ƒ|[ƒlƒ“ƒg‚ğƒAƒ^ƒbƒ`‚·‚é‚½‚ß‚Ì•Ï”
    public LineRenderer line;
    public float maxForce = 20f; // Å‘å—Í
    public float minForce = 5f; // Å¬—Í
    private Vector2 StartPosition; // ƒhƒ‰ƒbƒO‚ÌŠJnˆÊ’u
    private Vector2 EndPosition; // ƒhƒ‰ƒbƒO‚ÌI—¹ˆÊ’u
    public float gravityScale = 1.0f;  //d—Í‚ÌƒXƒP[ƒ‹
    public AudioClip onPressSound;
    public AudioClip onReleaseSound;
    private AudioSource audioSource;

    private bool first;  //ˆê‘Å–Úitrue‚¾‚Á‚½‚ç‘Å‚Ä‚éj

    void Start()
    {
        // ƒ{[ƒ‹‚ÌRigidbody2DƒRƒ“ƒ|[ƒlƒ“ƒg‚ğæ“¾
        ballRigidbody = GetComponent<Rigidbody2D>();

        line = GetComponent<LineRenderer>();

        // ü‚ÌŠJn‚ÆI—¹ˆÊ’u‚ğƒ{[ƒ‹‚ÌˆÊ’u‚Éİ’è
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

    // ƒ{[ƒ‹‚ğ”ò‚Î‚·ƒƒ\ƒbƒh
    void ShotBall()
    {

        // d—Í‚ğˆê“I‚É–³Œø‚É‚·‚é
        ballRigidbody.gravityScale = 0f;

        // ƒhƒ‰ƒbƒO‚µ‚½‹——£‚ğŒvZ
        float distance = Vector2.Distance(StartPosition, EndPosition);

        // ƒhƒ‰ƒbƒO‚µ‚½•ûŒü‚ğŒvZ
        Vector2 shootDirection = EndPosition - StartPosition;
        shootDirection.Normalize();

        // Šp“x‚ğŒvZ
        float angle = Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg;

        // ƒ{[ƒ‹‚É—Í‚ğ‰Á‚¦‚Ä”ò‚Î‚·
        float force = Mathf.Clamp(distance, minForce, maxForce); // ‹——£‚É‰‚¶‚½—Í‚ğ§ŒÀ
        Vector2 forceVector = Quaternion.AngleAxis(angle, Vector3.forward) * Vector2.right * force;
        ballRigidbody.AddForce(forceVector, ForceMode2D.Impulse);

        // d—Í‚ğ—LŒø‚É‚·‚é
        ballRigidbody.gravityScale = gravityScale;

        first = false;


    }

    //ƒ{[ƒ‹‚ÌˆÊ’u‚ğ’²ß‚·‚éƒƒ\ƒbƒh
    void Aim()
    {
        // ƒ}ƒEƒX‚Ì¶ƒNƒŠƒbƒN‚ª‰Ÿ‚³‚ê‚½‚ç
        if (Input.GetMouseButtonDown(0))
        {
            // ƒhƒ‰ƒbƒO‚ÌŠJnˆÊ’u‚ğæ“¾
            StartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

<<<<<<< HEAD
<<<<<<< HEAD
            line.SetPosition(0, new Vector3(-21.9f, -11.2f, 0));
=======
            line.SetPosition(0, new Vector3(-21.23f, -10.29f, 0));
>>>>>>> main
=======
            line.SetPosition(0, new Vector3(-21.23f, -10.29f, 0));
>>>>>>> e915c8e (9æœˆ10æ—¥ã‚¢ã‚»ãƒƒãƒˆè¿½åŠ )
        }
        // ƒ}ƒEƒX‚Ì¶ƒNƒŠƒbƒN‚ª—£‚³‚ê‚½‚ç
        else if (Input.GetMouseButtonUp(0))
        {
            // ƒhƒ‰ƒbƒO‚ÌI—¹ˆÊ’u‚ğæ“¾
            EndPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // ƒ{[ƒ‹‚ğ”ò‚Î‚·
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