using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameSystemController;

public class PauseScript2 : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseUI;
    GameObject _manager;
    GameSystemController controller;

    // Start is called before the first frame update
    void Start()
    {
        pauseUI.SetActive(false);
        _manager = GameObject.Find("GameManager");
        controller = _manager.GetComponent<GameSystemController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel") && controller._gameState != GameState.Result)
        {
            //�@�|�[�YUI�̃A�N�e�B�u�A��A�N�e�B�u��؂�ւ�
            pauseUI.SetActive(!pauseUI.activeSelf);

            //�@�|�[�YUI���\������Ă鎞�͒�~
            if (pauseUI.activeSelf)
            {
                Time.timeScale = 0f;
                //�@�|�[�YUI���\������ĂȂ���Βʏ�ʂ�i�s
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }
}
