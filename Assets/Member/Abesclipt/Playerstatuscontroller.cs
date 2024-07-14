using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerstatuscontroller : MonoBehaviour
{
    [SerializeField] float _speed;
    PlayerController _Controller;
    [SerializeField]float totalspeed;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
    }
    public void AddSpeedController(float addSpeed, float effecttime)
    {
        totalspeed = addSpeed + _speed;

    }
}
