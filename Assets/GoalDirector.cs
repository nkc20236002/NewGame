using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GoalDirector : MonoBehaviour
{
    public string sceneName; // �ڍs��̃V�[����
    public float delayTime = 2f; // �ڍs�܂ł̑ҋ@����

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("�S�[��");
            StartCoroutine(DelayedTransition());
            audioSource.Play();
        }
    }

    IEnumerator DelayedTransition()
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(sceneName);
    }
}