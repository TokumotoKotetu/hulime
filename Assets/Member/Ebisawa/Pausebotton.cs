using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameSystemController;

public class Pausebotton : MonoBehaviour
{
    [SerializeField] private GameObject pauseUIPrefab;
    private GameObject pauseUIInstance;
	GameObject _manager;
	GameSystemController controller;
   
    // Start is called before the first frame update
    void Start()
    {
		_manager = GameObject.Find("GameManager");
        controller = _manager.GetComponent<GameSystemController>();
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown ("Cancel") && controller._gameState != GameState.Result) {
			if (pauseUIInstance == null) {
				pauseUIInstance = GameObject.Instantiate (pauseUIPrefab) as GameObject;
				Time.timeScale = 0f;
			} 
			else {
				Destroy (pauseUIInstance);
				Time.timeScale = 1f;
			}
		}
	}
}
