using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KusaruController : MonoBehaviour
{
    [SerializeField] int _damage = 0;
    GameObject _player;
    PlayerIncreaseController _playerIncreaseController;
    PlayerController _playerController;

    private void Start()
    {
        _player = GameObject.Find("Range");
        _playerIncreaseController = _player.GetComponent<PlayerIncreaseController>();
        _playerController = _player.GetComponent<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(_playerController._invincible == true)
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "PlayerCopy" || collision.gameObject.tag == "Player")
        {
            Debug.Log("プレイヤーが当たった");

             _playerIncreaseController.Decrease(_damage);
             Debug.Log("ダメージ");
            Destroy(gameObject);
        }
    }
}
