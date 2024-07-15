using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KusaruController : MonoBehaviour
{
    [SerializeField] int _damage = 0;
    [SerializeField] AudioClip _getSound;
    GameObject _player;
    PlayerIncreaseController _playerIncreaseController;
    Playerstatuscontroller _playerController;

    private void Start()
    {
        _player = GameObject.Find("Range");
        _playerIncreaseController = _player.GetComponent<PlayerIncreaseController>();
        _playerController = _player.GetComponent<Playerstatuscontroller>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(_playerController._invincible)
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "PlayerCopy" || collision.gameObject.tag == "Player")
        {
            Debug.Log("ÉvÉåÉCÉÑÅ[Ç™ìñÇΩÇ¡ÇΩ");

            _playerIncreaseController.Decrease(_damage);
            SEController.Instance.RunSE(_getSound);
            Destroy(gameObject);
        }
    }
}
