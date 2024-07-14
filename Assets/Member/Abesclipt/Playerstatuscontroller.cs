using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerstatuscontroller : MonoBehaviour
{
    [SerializeField] float speed;
    PlayerController _Controller;
    float _additionSpeed;
    float _subtractionSpeed;

    float _speedUpTimer;
    float _speedDownTimer;

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
