using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetBotton : MonoBehaviour
{
    public string sceneName; // リセットするシーン名

    public void OnclickStartButton()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        // 対応するステージのシーン
=======
        // 対応するステージのシーン名入力
>>>>>>> main
=======
        // 対応するステージのシーン名入力
>>>>>>> e915c8e (9譛�10譌･繧｢繧ｻ繝�繝郁ｿｽ蜉�)
        SceneManager.LoadScene(sceneName);
    }

    public void finish()
    {
        // シーン切り替え3秒
        Invoke("Call", 0f);
    }

    void Call()
    {
        OnclickStartButton();
    }
}
