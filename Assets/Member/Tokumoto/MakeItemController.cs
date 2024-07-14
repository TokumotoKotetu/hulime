using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class MakeItemController : MonoBehaviour
{
    GameObject _gameManager;
    GameSystemController _gameSystemController;
    private void Start()
    {
        _gameManager = GameObject.Find("GameManager");
        _gameSystemController = _gameManager.GetComponent<GameSystemController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag=="PlayerCopy")
        {
            _gameSystemController.GameOver();
        }
    }
}
