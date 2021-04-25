using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.Rotate();
        this.Move();
    }

    private void Rotate()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput);
    }

    private void Move()
    {
        this.AjustSpeed();
        transform.Translate(Vector3.forward * Time.deltaTime * this.speed);
    }

    private void AjustSpeed()
    {
        if (Input.GetKey(KeyCode.Q)) this.speed++;
        if (Input.GetKey(KeyCode.E)) this.speed--;
    }
}
