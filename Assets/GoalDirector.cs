using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GoalDirector : MonoBehaviour
{
    public string sceneName; // 移行先のシーン名
    public float delayTime = 2f; // 移行までの待機時間

<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> e915c8e (9譛�10譌･繧｢繧ｻ繝�繝郁ｿｽ蜉�)
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

<<<<<<< HEAD
>>>>>>> main
=======
>>>>>>> e915c8e (9譛�10譌･繧｢繧ｻ繝�繝郁ｿｽ蜉�)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("ゴール");
            StartCoroutine(DelayedTransition());
<<<<<<< HEAD
<<<<<<< HEAD
=======
            audioSource.Play();
>>>>>>> main
=======
            audioSource.Play();
>>>>>>> e915c8e (9譛�10譌･繧｢繧ｻ繝�繝郁ｿｽ蜉�)
        }
    }

    IEnumerator DelayedTransition()
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(sceneName);
    }
}