using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;


public class rangerController : MonoBehaviour
{
    public Vector2 moveInput;
    Rigidbody2D rb; //rigidbody component of current object
    Animator anim;

    public float moveSpeed;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); //gets the rigidbody component of the current object
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
        changeAnimation();
    }

    private void OnMove(InputValue value)
    {
        //Debug.Log("here");
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput.x);

        //changeAnimation(moveInput.x, moveInput.y);
    } //automatically called with unity new input system the name of this function is based on the input mapping name

    private void MovePlayer()
    {
        Vector2 moveDirection = moveInput.normalized;
        Vector2 moveVelocity = moveDirection * moveSpeed;
        rb.velocity = moveVelocity;
    }

    private void changeAnimation()
    {
        if (moveInput.x == 1)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            anim.SetBool("running", true);
        } else if (moveInput.x == 0)
        {
            anim.SetBool("running", false);
        }

        if (moveInput.x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            anim.SetBool("running", true);
        }
    }
}
