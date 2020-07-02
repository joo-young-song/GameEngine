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

        AnimationUpdate();
    }

    void FixedUpdate()
    {
        Run(horizontalMove, verticalMove);
        Turn();
    }

    void Run(float h, float v)
    {
        movement.Set(h, 0, v);
        movement = movement.normalized * speed * Time.deltaTime;

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
    }
}
