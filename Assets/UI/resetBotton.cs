using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetBotton : MonoBehaviour
{
    public void OnclickStartButton()
    {
        // 対応するステージのシーン名入力
        SceneManager.LoadScene("");
    }

    public void finish()
    {
        // シーン切り替え3秒
        Invoke("Call", 3f);
    }

    void Call()
    {
        OnclickStartButton();
    }
}
