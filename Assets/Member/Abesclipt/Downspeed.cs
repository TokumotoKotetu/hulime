using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Downspeed : MonoBehaviour
{
    [SerializeField] float _downSpeedValue;
    [SerializeField] float _effectTime;
    [SerializeField] AudioClip _getSound;
    GameObject _player;
    Playerstatuscontroller _playerController;
    private void Start()
    {
        _player = GameObject.Find("Range");
        _playerController = _player.GetComponent<Playerstatuscontroller>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_playerController._invincible)
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("Player") || collision.CompareTag("PlayerCopy"))
        {
            GameObject.FindObjectOfType<Playerstatuscontroller>().SlowDownSpeed(_downSpeedValue, _effectTime);
            SEController.Instance.RunSE(_getSound);
            Destroy(gameObject);
        }
    }
}