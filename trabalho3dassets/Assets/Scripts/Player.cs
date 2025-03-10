using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    public int jumpForce = 10;
    private Rigidbody rb;
    //[SerializeField] public Animator Animator;
    public bool isGrounded;
    private CharacterController controller;
    public Transform cameraTransform;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }


    public void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ);
        move = cameraTransform.TransformDirection(move); // Alinha com a câmera

        controller.Move(move * speed * Time.deltaTime);
    }



}
