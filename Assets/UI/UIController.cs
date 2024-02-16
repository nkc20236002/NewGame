using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public Text masatu;
    public Text hanpatu;

    float m;
    float h;

    void Start()
    {
        
    }

    void Update()
    {
        var material = GetComponent<Rigidbody2D>().sharedMaterial;

        m = material.friction;
        h = material.bounciness;

        masatu.text = "–€ŽC—Í: " + m.ToString("N1");
        hanpatu.text = "”½”­—Í: " + h.ToString("N1");

    }
}
