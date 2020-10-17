using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    public float _speed;

    void Awake()
    {
        _speed = 6.4f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;

        if (transform.position.x <= -3.2f)
        {
            transform.position = new Vector3(3.2f, 0.0f, 1.0f);
        }
    }
}
