using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIncreaseController : MonoBehaviour
{
    [SerializeField] GameObject _playerPrefab;
    CircleCollider2D _circleCollider;
    Vector2 MakePos;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Increase();
        }
    }

    public void Increase()
    {
        _circleCollider = GetComponent<CircleCollider2D>();
        Vector2 playerPos = gameObject.transform.position;
        MakePos =  playerPos + _circleCollider.radius * Random.insideUnitCircle;

        GameObject obj = Instantiate(_playerPrefab);
        obj.transform.position = MakePos;
        obj.transform.parent = this.gameObject.transform;
    }
}
