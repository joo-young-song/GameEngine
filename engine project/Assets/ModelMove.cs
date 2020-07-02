using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelMove : MonoBehaviour
{

    public float speed = 10f;

    public float rotateSpeed = 1f;

    Rigidbody rigidbody;
    Animator animator;

    float horizontalMove;
    float verticalMove;
    float runMove;
    float jumpMove;

    Vector3 movement;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");
        runMove = Input.GetAxisRaw("Run");
        jumpMove = Input.GetAxisRaw("Jump");
    }

    void FixedUpdate()
    {
        Run(horizontalMove, verticalMove);
        Turn();
        AnimationUpdate();
    }

    void Run(float h, float v)
    {
        movement.Set(h, 0, v);

        if (runMove != 0)
            speed = speed * 2;

        movement = movement.normalized * speed * Time.deltaTime;

        if (runMove != 0)
            speed = speed / 2;

        rigidbody.MovePosition(transform.position + movement);
    }

    void Turn()
    {
        if (horizontalMove == 0 && verticalMove == 0)
            return;

        Quaternion newRotation = Quaternion.LookRotation(movement);

        rigidbody.rotation = Quaternion.Slerp(rigidbody.rotation, newRotation, rotateSpeed * Time.deltaTime);
    }

    void AnimationUpdate()
    {
        if(horizontalMove == 0 && verticalMove == 0 )
            animator.SetBool("isWalking", false);
        else
            animator.SetBool("isWalking", true);

        if (runMove == 0)
            animator.SetBool("isRunning", false);
        else
            animator.SetBool("isRunning", true);

        if(jumpMove == 0)
            animator.SetBool("isJump", false);
        else
            animator.SetBool("isJump", true);
    }
}
