using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masatumainasu : MonoBehaviour
{
    public void OnclickStartButton()
    {
        var material = GetComponent<Rigidbody2D>().sharedMaterial;
        material.friction -= 0.1f;
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
