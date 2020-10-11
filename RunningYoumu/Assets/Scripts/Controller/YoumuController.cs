using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoumuController : MonoBehaviour
{
    Animator _ani;
    Rigidbody2D _rigidBody;
    float _jumpPower;
    public bool IsJumping;


    void Awake()
    {
        _ani = GetComponent<Animator>();
        _ani.speed = 1.2f;

        _rigidBody = GetComponent<Rigidbody2D>();

        _jumpPower = 0f;
    }


    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            Jump();
        }
    }

    void Jump()
    {
        if (!IsJumping)
        {
            _rigidBody.AddForce(Vector3.up * _jumpPower, ForceMode2D.Impulse);
        }
    }

    bool IsJumpingCheck()
    {
        int layermask = 1 << LayerMask.NameToLayer("Floor");

        return IsJumping;
    }
}
