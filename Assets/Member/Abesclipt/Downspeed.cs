using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Downspeed : MonoBehaviour
{
    [SerializeField] float _downSpeedValue;
    [SerializeField] float _effectTime;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject.FindObjectOfType<Playerstatuscontroller>().SlowDownSpeed(_downSpeedValue, _effectTime);
            Destroy(gameObject);
        }
    }
}