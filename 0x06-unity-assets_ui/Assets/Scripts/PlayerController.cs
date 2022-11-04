using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    public float gravity;
    public Transform cameraTransform ;
    private Vector3 moveDirection = Vector3.zero;
    public GameObject player;
    public bool CollidedWithFlag = false;
    private CharacterController controller;
     private float originalStepOffset;
     Rigidbody rb;  
     void Start()
    {
        player = GameObject.Find("Player");
        rb = GetComponent<Rigidbody>();   
    }
    void Update() 
    {
        CharacterController controller = GetComponent<CharacterController>();
        
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = cameraTransform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }
        if (CollidedWithFlag == false)
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)
            || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)
            || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)
            || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                this.GetComponent<Timer>().enabled = true;
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
        if (transform.position.y < -25)
        {
            transform.position = new Vector3(0, 25, 0);  
        }
    }
}