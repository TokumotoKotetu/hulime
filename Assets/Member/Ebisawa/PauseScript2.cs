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
            //　ポーズUIのアクティブ、非アクティブを切り替え
            pauseUI.SetActive(!pauseUI.activeSelf);

            //　ポーズUIが表示されてる時は停止
            if (pauseUI.activeSelf)
            {
                Time.timeScale = 0f;
                //　ポーズUIが表示されてなければ通常通り進行
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }
}
