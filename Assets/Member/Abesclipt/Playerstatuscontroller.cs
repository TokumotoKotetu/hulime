using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerstatuscontroller : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float _requiredSlimes;
    [SerializeField] float _addRadius;
    float _startRadius;
    float _radius;
    PlayerController _Controller;
    CircleCollider2D _circleCollider2D;
    float _additionSpeed;
    float _subtractionSpeed;

    float _speedUpTimer;
    float _speedDownTimer;
    public bool _invincible = false;
    public int _slimecopyNumber = 0;
    private void Start()
    {
        _circleCollider2D = GetComponent<CircleCollider2D>();
        _startRadius = _circleCollider2D.radius;
        _radius = _circleCollider2D.radius;
    }
    public float TotalSpeed()
    {
        return speed + _additionSpeed - _subtractionSpeed;
    }

    void Update()
    {
        if (_speedUpTimer > 0)
        {
            _speedUpTimer -= Time.deltaTime;

            if (_speedUpTimer <= 0)
            {
                _additionSpeed = 0;
            }
        }
        if (_speedDownTimer > 0)
        {
            _speedDownTimer -= Time.deltaTime;

            if (_speedDownTimer <= 0)
            {
                _subtractionSpeed = 0;
            }
        }

        GameObject[] a = GameObject.FindGameObjectsWithTag("PlayerCopy");
        _slimecopyNumber = a.Length;

        _circleCollider2D.radius = _radius;


        _radius = _startRadius +  (_addRadius *(_slimecopyNumber / _requiredSlimes));
        
    }
    public void AddSpeedController(float addSpeed, float effecttime)
    {
        _additionSpeed = addSpeed;
        _speedUpTimer += effecttime;
    }

    public void SlowDownSpeed(float subtractSpeed, float effectTime)
    {
        _subtractionSpeed = subtractSpeed;
        _speedDownTimer = effectTime;
    }
}
