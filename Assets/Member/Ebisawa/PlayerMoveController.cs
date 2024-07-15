using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float speed = 1.0f;
    float x, y;
    GameSystemController _gameSystem;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        _gameSystem = FindFirstObjectByType<GameSystemController>();
    }

    void Update()
    {

        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        if (_gameSystem._gameState != GameSystemController.GameState.RunGame)
        {
            rb2d.velocity = Vector2.zero;
            return;
        }
        var _speed = new Vector2(x,y);
        rb2d.velocity = _speed.normalized * speed;
    }
}