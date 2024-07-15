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
    public GameState _gameState;
    void Start()
    {
        _gameState = GameState.RunGame;
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
            GameOver();
        }
    }

    public void AddTime(float addTime)
    {
        _time += addTime;
    }

    public void GameOver()
    {
        _gameOverPanel.SetActive(true);
        _gameState = GameState.Result;
        Time.timeScale = 0;
    }

    public enum GameState{ Ready,RunGame,Result}
}
