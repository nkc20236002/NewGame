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
        // ƒV[ƒ“Ø‚è‘Ö‚¦3•b
        Invoke("Call", 0);
    }

    void Call()
    {
        OnclickStartButton();
    }

}
