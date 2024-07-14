using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class MakeItemController : MonoBehaviour
{
    GameObject _gameManager;
    GameSystemController _gameSystemController;
    GameObject _player;
    PlayerController _playerController;
    private void Start()
    {
        _gameManager = GameObject.Find("GameManager");
        _gameSystemController = _gameManager.GetComponent<GameSystemController>();
        _player = GameObject.Find("Range");
        _playerController = _player.GetComponent<PlayerController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(_playerController._invincible)
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag=="PlayerCopy")
        {
            _gameSystemController.GameOver();
        }
    }
}
