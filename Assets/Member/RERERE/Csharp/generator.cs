using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    [SerializeField] GameObject _itemPrefab;
    /// <summary>  アイテム再出現までの時間 </summary>
    [SerializeField]float _coolTime = 3.0f;
    /// <summary> 経過時間測定用 </summary>
    float _coolTimeCount = 0f;

    Vector3 _position;

    [SerializeField]BoxCollider2D boxCollider2D;

    [SerializeField] Vector2 _moveDir;
    // Start is called before the first frame update
    void Start()
    {
        
        _position = transform.position;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float randomX = Random.Range(-boxCollider2D.size.x, boxCollider2D.size.x)*0.5f;
        float randomY = Random.Range(-boxCollider2D.size.y, boxCollider2D.size.y)*0.5f;

        _coolTimeCount += Time.deltaTime;
        

        if (_coolTimeCount > _coolTime)
        {
            var item = Instantiate(_itemPrefab,new Vector3(_position.x+randomX,_position.y+randomY,0), Quaternion.identity);
            item.GetComponent<ItemMovementController>().MoveDir = _moveDir;
            _coolTimeCount = 0;
        }
        
    }
    
}
