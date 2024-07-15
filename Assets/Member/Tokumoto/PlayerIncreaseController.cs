using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIncreaseController : MonoBehaviour
{
    [SerializeField] GameObject _playerPrefab;
    [SerializeField] GameObject _player;
    CircleCollider2D _circleCollider;
    Vector2 MakePos;

    public bool _huku = false;

    // Update is called once per frame
    void Update()
    {
    }

    public void Increase(int addNumber)
    {
        for(int i  = 0; i < addNumber; i++)
        {
            _circleCollider = GetComponent<CircleCollider2D>();
            Vector2 playerPos = gameObject.transform.position;
            MakePos = playerPos + _circleCollider.radius * Random.insideUnitCircle;

            GameObject obj = Instantiate(_playerPrefab);
            obj.transform.position = MakePos;
            obj.transform.parent = _player.gameObject.transform;
        }
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
            }
        }
        else
        {
            foreach(GameObject copy in players)
            {
                Destroy(copy);
            }
        }
    }

    public void StartHuku(float _invincibleTime)
    {
        StartCoroutine(Huku(_invincibleTime));
    }
    public IEnumerator Huku(float _invincibleTime)
    {
        _huku = true;
        GameObject player = GameObject.Find("Range");
        var PlayerStats = FindObjectOfType<Playerstatuscontroller>();
        PlayerStats._invincible = true;
        Debug.Log(_invincibleTime);
        yield return new WaitForSeconds(_invincibleTime);
        Debug.Log("ñ≥ìGâèú");
        _huku = false;
        PlayerStats._invincible = false;


    }
}
