using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController1 : MonoBehaviour
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
        transform.position = new Vector3(playerTransform.position.x , playerTransform.position.y , transform.position.z);
        //‚±‚±‚ÅƒJƒƒ‰‚Ì‚‚³“™•ÏX
    }
}
