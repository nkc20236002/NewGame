using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanpatupurasu : MonoBehaviour
{
    public void OnclickStartButton()
    {
        var material = GetComponent<Rigidbody2D>().sharedMaterial;
        material.bounciness += 0.1f;
    }
    public void finish()
    {
        // �V�[���؂�ւ�3�b
        Invoke("Call", 0);
    }

    void Call()
    {
        OnclickStartButton();
    }
}
