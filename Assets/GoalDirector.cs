using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GoalDirector : MonoBehaviour
{
    public string sceneName; // �ڍs��̃V�[����
    public float delayTime = 2f; // �ڍs�܂ł̑ҋ@����

<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> e915c8e (9月10日アセット追加)
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

<<<<<<< HEAD
>>>>>>> main
=======
>>>>>>> e915c8e (9月10日アセット追加)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("�S�[��");
            StartCoroutine(DelayedTransition());
<<<<<<< HEAD
<<<<<<< HEAD
=======
            audioSource.Play();
>>>>>>> main
=======
            audioSource.Play();
>>>>>>> e915c8e (9月10日アセット追加)
        }
    }

    IEnumerator DelayedTransition()
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(sceneName);
    }
}