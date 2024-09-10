using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetBotton : MonoBehaviour
{
    public string sceneName; // リセットするシーン名

    public void OnclickStartButton()
    {
        // 対応するステージのシーン名入力
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
