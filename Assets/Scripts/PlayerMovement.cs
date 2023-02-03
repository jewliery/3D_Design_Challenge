using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5f;
    public float gravity = 9.87f;
    public float verticalSpeed = 0.0f;
    public float mouseSensitivity = 2.0f;

    public bool visited = false;

    private CharacterController _controller;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Movement();
        MyRotate();
    }

    void Movement()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        if (_controller.isGrounded)
            verticalSpeed = 0.0f;
        else
            verticalSpeed -= gravity * Time.deltaTime;

        Vector3 gravityMove = new Vector3(0, verticalSpeed, 0);
        Vector3 move = transform.forward * verticalMove + transform.right * horizontalMove; 
        _controller.Move(move * Speed * Time.deltaTime + gravityMove * Speed * Time.deltaTime);
    }

    void MyRotate()
    {
        float horizontalRotation = Input.GetAxis("Mouse X");
        float verticalRotation = Input.GetAxis("Mouse Y");

        transform.Rotate(0, horizontalRotation * mouseSensitivity, 0);


    }
}