using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    public float velocidadeRotacao = 5;
    public int jumpForce = 10;
    private Rigidbody rb;
    //[SerializeField] public Animator Animator;
    public bool isGrounded;
   
    public Transform cameraTransform;
    public Animator animator;
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        
    }
    private void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetBool("Smoking", true);
          //  Camera.main.transform.position = new Vector3(-0.4f, 1.95f, -2.14f);
            //Camera.main.transform.rotation = Quaternion.Euler(0f, -182.01f, 0f);
        }

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Running", true);
        }
        else
        {
            animator.SetBool("Running", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Jump", true);
            
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("Dancing", true);

        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            animator.SetBool("Laydown", true);

        }  
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            animator.SetBool("Punching", true);

        }

    }

    public void Move()
    {
        float moveX = Input.GetAxis("Horizontal"); // "A" e "D" ou Setas
        float moveZ = Input.GetAxis("Vertical");   // "W" e "S" ou Setas

        Vector3 move = new Vector3(moveX, 0, moveZ) * speed * Time.deltaTime;
        transform.Translate(move, Space.World);

        Vector3 direcao = new Vector3(moveX, 0, moveZ).normalized;

        Quaternion novaRotacao = Quaternion.LookRotation(direcao);

        transform.rotation = Quaternion.Slerp(transform.rotation, novaRotacao, velocidadeRotacao * Time.deltaTime);
    }

    



}
