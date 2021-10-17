using UnityEngine;
using System;


[RequireComponent(typeof(Rigidbody2D))]
public class MyPlayerMovement : MonoBehaviour
{

    public static event Action OnPickUpFood;

    [Header("Player Property")]
    [SerializeField] private float _playerSpeed;
    [SerializeField] private float _playerJumpForce;
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private float _currentPlayerSpeed;
    private Rigidbody2D _rb;
    private bool _groundCheck;
    

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        
        _rb.velocity = new Vector2(_currentPlayerSpeed*Time.deltaTime, _rb.velocity.y);
       _animator.SetFloat("Speed", Mathf.Abs(_currentPlayerSpeed));
    }
      
    public void RightMove()
    {
        _currentPlayerSpeed = _playerSpeed;
        if (transform.localScale.x < 0)
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.y);
        }
    }
    public void LeftMove()
    {
        _currentPlayerSpeed = -_playerSpeed;
        if (transform.localScale.x > 0)
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.y);
        }
    }

    public void Attack()
    {
        _animator.SetTrigger("Attack");
    }
     
    public void StopMove()
    {
        _currentPlayerSpeed = 0f;
    }
    
    public void Jump()
    {
        if (_groundCheck)
        {
            _animator.SetTrigger("Jump");
            _rb.velocity = new Vector2(_rb.velocity.x, _playerJumpForce);
            _groundCheck = false;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _groundCheck = true;

        Fructs fructs = collision.GetComponent<Fructs>();
        if (fructs != null)
        {
            fructs.GiveScore();
            OnPickUpFood?.Invoke();
        }

    }

}






//if (transform.localScale.x > 0)
//{
//    transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.y);
//}