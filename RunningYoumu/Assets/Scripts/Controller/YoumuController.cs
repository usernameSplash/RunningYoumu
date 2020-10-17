using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoumuController : MonoBehaviour
{
    Animator _ani;
    Rigidbody2D _rigidBody;
    BoxCollider2D _collider;
    float _jumpPower;
    public bool IsJumping;


    void Awake()
    {
        _ani = GetComponent<Animator>();
        _ani.speed = 1.2f;

        _rigidBody = GetComponent<Rigidbody2D>();

        _collider = GetComponent<BoxCollider2D>();

        _jumpPower = 5.0f;
    }


    void Update()
    {
        IsJumping = IsJumpingCheck();

        if (Input.GetButtonDown("Jump") && !IsJumping)
        {
            Debug.Log("Jump");
            Jump();
        }
    }

    void Jump()
    {
        _rigidBody.AddForce(Vector3.up * _jumpPower, ForceMode2D.Impulse);
    }

    bool IsJumpingCheck()
    {
        int layermask = 1 << LayerMask.NameToLayer("Floor");

        if (_collider.IsTouchingLayers(layermask))
        {
            _ani.SetBool("isJump", false);
            IsJumping = false;
        }
        else
        {
            _ani.SetBool("isJump", true);
            IsJumping = true;
        }


        return IsJumping;
    }
}
