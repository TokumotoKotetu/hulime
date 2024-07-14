using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovementController : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 1;
    Rigidbody2D _rigidbody2D;
    Vector2 _moveDir;

    public Vector2 MoveDir
    {
        get => _moveDir;
        set => _moveDir = value;
    }

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _rigidbody2D.velocity = MoveDir * _moveSpeed;
    }
}
