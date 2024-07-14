using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] GameObject _player;
    //playerスクリプト取得
    private void Update()
    {
        //アイテム移動
        transform.position += Vector3.left * Time.deltaTime;
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.CompareTag("Player"))
        {
            //衝突した時の処理を書く
        }
    }
}
