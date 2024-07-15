using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseItem : MonoBehaviour
{
    [SerializeField] int _addSlimeNumber;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject _player = GameObject.Find("Range");
        PlayerIncreaseController controller = _player.GetComponent<PlayerIncreaseController>();
        if (collision.tag == "Player" || collision.tag == "PlayerCopy")
        {
            controller.Increase(_addSlimeNumber);
            Destroy(gameObject);
        }
        
    }
}
