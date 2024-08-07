using UnityEngine;

public class Upspeed : MonoBehaviour
{
    [SerializeField] float _upSpeedValue;
    [SerializeField] float _effectTime;
    [SerializeField] AudioClip _getSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("PlayerCopy"))
        {
            GameObject.FindObjectOfType<Playerstatuscontroller>().AddSpeedController(_upSpeedValue, _effectTime);
            SEController.Instance.RunSE(_getSound);
            Destroy(gameObject);
        }
    }
}