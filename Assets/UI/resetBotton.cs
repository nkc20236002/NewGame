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
<<<<<<< HEAD
        // �Ή�����X�e�[�W�̃V�[��
=======
        // �Ή�����X�e�[�W�̃V�[��������
>>>>>>> main
=======
        // �Ή�����X�e�[�W�̃V�[��������
>>>>>>> e915c8e (9月10日アセット追加)
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
