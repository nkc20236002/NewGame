using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetBotton : MonoBehaviour
{
    public void OnclickStartButton()
    {
        // �Ή�����X�e�[�W�̃V�[��������
        SceneManager.LoadScene("");
    }

    public void finish()
    {
        // �V�[���؂�ւ�3�b
        Invoke("Call", 3f);
    }

    void Call()
    {
        OnclickStartButton();
    }
}
