using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.EventSystems.EventTrigger;


public class RankingUI : MonoBehaviour
{
    [SerializeField] RankingManager rankingManager;

    [SerializeField] Text[] _rankingTexts;
    [SerializeField] Text _newScoreText;

    void Start()
    {
        //rankingManager.LoadRanking();
        //DisplayRanking();
    }

    private void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    rankingManager.AddRankingEntry(Random.Range(0, 100));
        //}

        //if (Input.GetMouseButtonDown(1))
        //{
        //    DisplayRanking();
        //}
    }

    public void DisplayRanking(int newScore)
    {
        //foreach(Transform child in rankingContainer)
        //{
        //    Destroy(child);
        //}

        rankingManager.AddRankingEntry(newScore);
        rankingManager.LoadRanking();
        int[] ranking = rankingManager.GetRankingEntries();
        Debug.Log(ranking.Length);
        for (int i = 0; i < ranking.Length; i++)
        {
            _rankingTexts[i].text = ranking[i].ToString();
        }

        _newScoreText.text = newScore.ToString();
    }
}
