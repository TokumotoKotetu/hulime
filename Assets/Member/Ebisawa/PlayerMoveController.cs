using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float speed = 1.0f;
    [SerializeField] float _moveSoundInterval;
    [SerializeField] AudioClip _moveSE;
    [SerializeField] AudioClip _wallSE;
    float x, y;
    GameSystemController _gameSystem;
    Playerstatuscontroller _playerstatus;
    float timer = 0;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        _gameSystem = FindFirstObjectByType<GameSystemController>();
        _playerstatus = GetComponent<Playerstatuscontroller>();
    }

    void Update()
    {

        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        speed = _playerstatus.TotalSpeed();

        if(x !=0 && y !=0)
        {
            timer += Time.deltaTime;
        }

        if(_moveSoundInterval < timer)
        {
            SEController.Instance.RunSE(_moveSE);
            timer = 0;
        }
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SEController.Instance.RunSE(_wallSE);
    }
}