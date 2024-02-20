using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class onoff : MonoBehaviour
{
    // bool ball;
    public GameObject balla;

    void Start()
    {
        
    }

    public void OnclickStartButton()
    {
        // ball = GameObject.Find("Circle").activeSelf;
        

        if(balla.activeSelf == true)
        {
            balla.SetActive(false);
            Debug.Log("Off");
        }
        else if(balla.activeSelf == false)
        {
            balla.SetActive(true);
            Debug.Log("On");
        }
    }
    public void finish()
    {
        Invoke("Call", 0);
    }

    void Call()
    {
        OnclickStartButton();
    }
}
