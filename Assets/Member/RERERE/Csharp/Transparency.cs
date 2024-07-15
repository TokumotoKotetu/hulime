using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparency : MonoBehaviour
{
    SpriteRenderer sr;

    float transparency = 0.0f;
    bool _isBlinking;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        var PlayerIncreaseController = GetComponent<PlayerIncreaseController>();
        var PlayerStats = FindObjectOfType<Playerstatuscontroller>();

        if (PlayerStats._invincible == true&&_isBlinking==false)
        {
            
            StartCoroutine("Blinking");           
        }
    }
    public IEnumerator Blinking()
    {
        _isBlinking = true;
        Debug.Log("Blinking");
        sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 0);
        yield return new WaitForSeconds(0.2f);
        sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 255);
        yield return new WaitForSeconds(0.2f);
        _isBlinking = false;
    }

     
}
