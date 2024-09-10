using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GoalDirector : MonoBehaviour
{
    public string sceneName; // 移行先のシーン名
    public float delayTime = 2f; // 移行までの待機時間

<<<<<<< HEAD
=======
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

>>>>>>> main
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("ゴール");
            StartCoroutine(DelayedTransition());
<<<<<<< HEAD
=======
            audioSource.Play();
>>>>>>> main
        }
    }

    IEnumerator DelayedTransition()
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(sceneName);
    }
}