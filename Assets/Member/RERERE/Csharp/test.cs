using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] GameObject _player;
    //player�X�N���v�g�擾
    private void Update()
    {
        //�A�C�e���ړ�
        transform.position += Vector3.left * Time.deltaTime;
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.CompareTag("Player"))
        {
            //�Փ˂������̏���������
        }
    }
}
