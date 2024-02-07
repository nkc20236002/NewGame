using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject playerObjct;
    Transform playerTransform;

    void Start()
    {
        playerObjct = GameObject.FindGameObjectWithTag("Player");
        playerTransform = playerObjct.transform;
    }


    void Update()
    {
        transform.position = new Vector3(playerTransform.position.x + 5, playerTransform.position.y + 3, transform.position.z);
        //‚±‚±‚ÅƒJƒƒ‰‚Ì‚‚³“™•ÏX
    }
}
