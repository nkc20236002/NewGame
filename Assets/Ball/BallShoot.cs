using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShoot : MonoBehaviour
{
    private Rigidbody2D _rb;
    private LineRenderer _rend;

    private float power = 10.0f;
    private float maxPower = 40.0f;

    private Vector2 StartPos;
    private Vector2 EndPos;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rend = GetComponent<LineRenderer>();
    }

    private void OnMouseDown()
    {
        StartPos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _rend.SetPosition(1, transform.position);
    }
    private void OnMouseUp()
    {
        _rend.enabled = false;
        EndPos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 force = Vector2.ClampMagnitude((StartPos - EndPos), maxPower);
        _rb.AddForce(force * power, ForceMode2D.Impulse);
    }
}