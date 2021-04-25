using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 20f;
    public float TurnSpeed;

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
        Turn();
    }

    private void Move()
    {
        float inputSpeed = Input.GetAxis("Vertical");
        this.transform.Translate(Vector3.forward * Time.deltaTime * this.Speed * inputSpeed);
    }

    private void Turn()
    {
        float inputSpeed = Input.GetAxis("Horizontal");
        this.transform.Rotate(Vector3.up,  Time.deltaTime * this.TurnSpeed * inputSpeed);
    }

}
