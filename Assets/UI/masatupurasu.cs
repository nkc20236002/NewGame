using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class masatupurasu : MonoBehaviour
{
    public void OnclickStartButton()
    {
        var material = GetComponent<Rigidbody2D>().sharedMaterial;
        material.friction += 0.1f;
    }
    public void finish()
    {
        // シーン切り替え3秒
        Invoke("Call", 0);
    }

    void Call()
    {
        OnclickStartButton();
    }

}
