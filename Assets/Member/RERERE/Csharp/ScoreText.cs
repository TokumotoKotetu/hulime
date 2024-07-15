using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    GameObject Player;
    Playerstatuscontroller Playerstatuscontroller;

    [SerializeField] Text _scoreTexr;
    // Start is called before the first frame update
    void Start()
    {
        Player=GameObject.Find("Range");
        Playerstatuscontroller = Player.GetComponent<Playerstatuscontroller>();
    }

    // Update is called once per frame
    void Update()
    {
        int score= Playerstatuscontroller._slimecopyNumber;
        _scoreTexr.text = score.ToString("000");
    }
}
