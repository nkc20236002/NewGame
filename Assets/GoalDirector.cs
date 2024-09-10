using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GoalDirector : MonoBehaviour
{
    public string sceneName; // 移行先のシーン名
    public float delayTime = 2f; // 移行までの待機時間

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("ゴール");
            StartCoroutine(DelayedTransition());
        }
    }

    IEnumerator DelayedTransition()
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(sceneName);
    }
}