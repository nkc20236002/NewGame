using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetBotton : MonoBehaviour
{
    public string sceneName; // ���Z�b�g����V�[����

    public void OnclickStartButton()
    {
<<<<<<< HEAD
        // �Ή�����X�e�[�W�̃V�[��
=======
        // �Ή�����X�e�[�W�̃V�[��������
>>>>>>> main
        SceneManager.LoadScene(sceneName);
    }

    public void finish()
    {
        // �V�[���؂�ւ�3�b
        Invoke("Call", 0f);
    }

    void Call()
    {
        OnclickStartButton();
    }
}
