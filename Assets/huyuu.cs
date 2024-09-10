using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class huyuu : MonoBehaviour
{
    // �����ʒu
    private Vector3 startPos;

    // �������鍂��
    public float floatHeight = 0.5f;

    // �������x
    public float floatSpeed = 1.0f;

    void Start()
    {
        // �����ʒu��ۑ�
        startPos = transform.position;
    }

    void Update()
    {
        // y�������̕������v�Z
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        // �V�����ʒu��ݒ�
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
