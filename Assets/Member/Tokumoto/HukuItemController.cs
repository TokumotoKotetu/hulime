using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HukuItemController : MonoBehaviour
{
    [SerializeField] float _invincibleTime = 5;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player"||collision.tag == "PlayerCopy")
        {
            GameObject gameObject = GameObject.Find("Range");
            PlayerIncreaseController controller = gameObject.GetComponent<PlayerIncreaseController>();
            StartCoroutine(controller.Huku(_invincibleTime));
            Destroy(this.gameObject);
        } 
    }

}
