using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AddTimeController : MonoBehaviour
{
    [SerializeField] float _addTime;
    [SerializeField] int _addSlimeNumber;
    [SerializeField] AudioClip _getSound;
    GameObject _gameManager;
    GameSystemController _gameSystemController;
    private void Start()
    {
        _gameManager = GameObject.Find("GameManager");
        _gameSystemController = _gameManager.GetComponent<GameSystemController>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = GameObject.Find("Range");
        PlayerIncreaseController controller = player.GetComponent<PlayerIncreaseController>();
        if (collision.tag == "Player" || collision.tag == "PlayerCopy")
        {
            _gameSystemController.AddTime(_addTime);
            controller.Increase(_addSlimeNumber);
            SEController.Instance.RunSE(_getSound);
            Destroy(gameObject);
        }
    }
}
