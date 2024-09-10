using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homeBotton : MonoBehaviour
{
    public void OnclickStartButton()
    {
        // タイトルシーン
        SceneManager.LoadScene("");
    }

    public void finish()
    {
        Invoke("Call", 0f);
    }

    void Call()
    {
        OnclickStartButton();
    }
}
