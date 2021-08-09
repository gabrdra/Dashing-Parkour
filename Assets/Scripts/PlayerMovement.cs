using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float movementSpeed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;


    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public Transform wallRunCheck;
    public float wallRunDistance = 0.6f;
    public LayerMask wallRunMask;

    Vector3 velocity;
    bool isGrounded;
    bool isWallRunning;

    private float jumpForce;

    public float jumpGracePeriod = 0.2f;
    private float lastTimeOnGround = 0f;

    private void Start()
    {
        jumpForce = Mathf.Sqrt(jumpHeight * -2f * gravity);
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        isWallRunning = Physics.CheckSphere(wallRunCheck.position, wallRunDistance, wallRunMask);
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * movementSpeed * Time.deltaTime);
        if (isGrounded)
        {
            lastTimeOnGround = Time.time;
        }
        if (Input.GetButtonDown("Jump") && (lastTimeOnGround >= Time.time - jumpGracePeriod))
        {
            velocity.y = jumpForce;
        }
        if (isWallRunning && (x != 0 || z != 0))
        {
            velocity.y += (gravity / 3f) * Time.deltaTime;
        }
        else
        {
            velocity.y += gravity * Time.deltaTime;
        }
        controller.Move(velocity * Time.deltaTime);
    }
}
