using System.Collections;
using UnityEngine;

public class InvincibilityTime : MonoBehaviour
{
    [SerializeField] float _invincibleTimeTow = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DeBuff"))
        {
            StartCoroutine("Invincibility");
        }
    }
    public IEnumerator Invincibility()
    {
        var PlayerIncreaseController = GetComponent<PlayerIncreaseController>();
        var PlayerStats = FindObjectOfType<Playerstatuscontroller>();
        PlayerStats._invincible = true;
        Debug.Log(_invincibleTimeTow);
        yield return new WaitForSeconds(_invincibleTimeTow);

        //福アイテムの効果が切れているなら実行
        //福の効果が乗っているときには実行しない
        if (PlayerIncreaseController._huku == false)
        {
            PlayerStats._invincible = false;
        }

    }
}
