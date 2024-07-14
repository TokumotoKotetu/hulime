using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSystemController : MonoBehaviour
{
    [SerializeField] Text _timerText;
    [SerializeField] GameObject _gameOverPanel;
    [SerializeField] float _startTime;
    float _time;
    void Start()
    {
        _time = _startTime;
        _gameOverPanel.SetActive(false);
    }

    void Update()
    {
        if(_time > 0)
        {
            _time -= Time.deltaTime;
            _timerText.text = _time.ToString("F2");
        }
        else
        {
            _gameOverPanel.SetActive(true);
        }
    }
}
