using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HukuItemController : MonoBehaviour
{
    [SerializeField] float _invincibleTime = 5;
    [SerializeField] int _addSlimeNumber;
    [SerializeField] AudioClip _getSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player"||collision.tag == "PlayerCopy")
        {
            GameObject gameObject = GameObject.Find("Range");
            PlayerIncreaseController controller = gameObject.GetComponent<PlayerIncreaseController>();
            controller.StartHuku(_invincibleTime);
            controller.Increase(_addSlimeNumber);
            SEController.Instance.RunSE(_getSound);
            Destroy(this.gameObject);
        } 
    }

}
