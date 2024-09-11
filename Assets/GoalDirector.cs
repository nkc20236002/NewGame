using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GoalDirector : MonoBehaviour
{
    public string sceneName; // ˆÚsæ‚ÌƒV[ƒ“–¼
    public float delayTime = 2f; // ˆÚs‚Ü‚Å‚Ì‘Ò‹@ŠÔ

<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> e915c8e (9æœˆ10æ—¥ã‚¢ã‚»ãƒƒãƒˆè¿½åŠ )
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

<<<<<<< HEAD
>>>>>>> main
=======
>>>>>>> e915c8e (9æœˆ10æ—¥ã‚¢ã‚»ãƒƒãƒˆè¿½åŠ )
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("ƒS[ƒ‹");
            StartCoroutine(DelayedTransition());
<<<<<<< HEAD
<<<<<<< HEAD
=======
            audioSource.Play();
>>>>>>> main
=======
            audioSource.Play();
>>>>>>> e915c8e (9æœˆ10æ—¥ã‚¢ã‚»ãƒƒãƒˆè¿½åŠ )
        }
    }

    IEnumerator DelayedTransition()
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(sceneName);
    }
}