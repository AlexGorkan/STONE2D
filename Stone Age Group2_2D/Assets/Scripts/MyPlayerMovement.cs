using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[RequireComponent(typeof(Rigidbody2D))]
public class MyPlayerMovement : MonoBehaviour
{

    public static event Action GetPoints;
    [Header("Player Property")]
    [SerializeField] private float playerSpeed;
    [SerializeField] private float playerJumpForce;
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private float currentPlayerSpeed;
    private Rigidbody2D rb;
    private bool groundCheck;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        
        rb.velocity = new Vector2(currentPlayerSpeed*Time.deltaTime, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(currentPlayerSpeed));
    }
      
    public void RightMove()
    {
        currentPlayerSpeed = playerSpeed;
        if (transform.localScale.x < 0)
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.y);
        }
    }
    public void LeftMove()
    {
        currentPlayerSpeed = -playerSpeed;
        if (transform.localScale.x > 0)
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.y);
        }
    }

    public void Attack()
    {
        animator.SetTrigger("Attack");
    }
     
    public void StopMove()
    {
        currentPlayerSpeed = 0f;
    }
    
    public void Jump()
    {
        if (groundCheck)
        {
            animator.SetTrigger("Jump");
            rb.velocity = new Vector2(rb.velocity.x, playerJumpForce);
            groundCheck = false;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        groundCheck = true;

        Fructs fructs = collision.GetComponent<Fructs>();
        if (fructs != null)
        {
            GetPoints?.Invoke();
            collision.gameObject.SetActive(false);

        }

    }

}






//if (transform.localScale.x > 0)
//{
//    transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.y);
//}