using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseItem : MonoBehaviour
{
    [SerializeField] int _addNumber;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject _player = GameObject.Find("Range");
        PlayerIncreaseController _playerIncreaseController;
        _playerIncreaseController = _player.GetComponent<PlayerIncreaseController>();
        if (collision.tag == "Player" || collision.tag == "PlayerCopy")
        {
            for (int i = 0; i < _addNumber; i++)
            {
                _playerIncreaseController.Increase();
            }
            Destroy(gameObject);
        }
        
    }
}
