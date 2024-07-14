using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausebotton : MonoBehaviour
{
    [SerializeField] private GameObject pauseUIPrefab;
    private GameObject pauseUIInstance;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown ("Cancel")) {
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
