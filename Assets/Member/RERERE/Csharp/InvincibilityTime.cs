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

        //���A�C�e���̌��ʂ��؂�Ă���Ȃ���s
        //���̌��ʂ�����Ă���Ƃ��ɂ͎��s���Ȃ�
        if (PlayerIncreaseController._huku == false)
        {
            PlayerStats._invincible = false;
        }

    }
}
