using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIncreaseController : MonoBehaviour
{
    [SerializeField] GameObject _playerPrefab;
    [SerializeField] GameObject _player;
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
        if (Input.GetKeyDown(KeyCode.G))
        {
            Decrease(1);
        }
    }

    public void Increase()
    {
        _circleCollider = GetComponent<CircleCollider2D>();
        Vector2 playerPos = gameObject.transform.position;
        MakePos =  playerPos + _circleCollider.radius * Random.insideUnitCircle;

        GameObject obj = Instantiate(_playerPrefab);
        obj.transform.position = MakePos;
        obj.transform.parent = _player.gameObject.transform;
    }

    public void Decrease(int damage)
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("PlayerCopy");
        if(damage <= players.Length)
        {
            for(int i = 0; i < damage; i++)
            {
                if (players[i] != null)
                {
                    Destroy(players[i]);
                }
                else
                {
                    //ゲームオーバー
                }                  
            }
        }
        else
        {
            Debug.Log("ゲームオーバー");
            //Gameover();
            foreach(GameObject copy in players)
            {
                Destroy(copy);
            }
        }
    }
}
