using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homeBotton : MonoBehaviour
{
    public void OnclickStartButton()
    {
        // �^�C�g���V�[��
        SceneManager.LoadScene("");
    }

    public void finish()
    {
        Invoke("Call", 3f);
    }

    void Call()
    {
        OnclickStartButton();
    }
}
