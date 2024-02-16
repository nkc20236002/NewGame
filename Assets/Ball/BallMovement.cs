using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    void Start()
    {
        var material = GetComponent<Rigidbody2D>().sharedMaterial;

        material.friction = 0.5f;
        material.bounciness = 1.0f;
    }
}
