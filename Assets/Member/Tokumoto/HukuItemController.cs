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
            StartCoroutine(Huku());
            Destroy(gameObject);
        } 
    }
    public IEnumerator Huku()
    {
        GameObject player = GameObject.Find("Range");
        var playerController = player.GetComponent<PlayerController>();
        playerController._invincible = true;
        Debug.Log("ñ≥ìGäJén");
        yield return new WaitForSeconds(_invincibleTime);
        playerController._invincible = false;
        Debug.Log("ñ≥ìGâèú");
        
    }
}
