using UnityEngine;

public class Upspeed : MonoBehaviour
{
    [SerializeField] float _upSpeedValue;
    [SerializeField] float _effectTime;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject.FindObjectOfType<Playerstatuscontroller>().AddSpeedController(_upSpeedValue, _effectTime);
            Destroy(gameObject);
        }
    }
}