using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KazeItemController : MonoBehaviour
{
    [SerializeField] float _explosivePower = 1f;
    [SerializeField] AudioClip _getSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" ||  collision.tag == "PlayerCopy")
        {
            Debug.Log("ÉvÉåÉCÉÑÅ[Ç™ìñÇΩÇ¡ÇΩ");
            GameObject[] DeBuffItems = GameObject.FindGameObjectsWithTag("DeBuff");
            for(int i = 0; i < DeBuffItems.Length; i++)
            {
                
                var circleCollider = DeBuffItems[i].GetComponent<CircleCollider2D>();                 
                circleCollider.enabled = false;

                var rigidbody2D = DeBuffItems[i].GetComponent<Rigidbody2D>();
                Vector2 force = new Vector2(Random.Range(-180,180), Random.Range(-180, 180));
                Debug.Log(force);
                force = force.normalized * _explosivePower;
                rigidbody2D.AddForce(force,ForceMode2D.Impulse);
            }
            SEController.Instance.RunSE(_getSound);
            Destroy(gameObject);
        }
    }
}
