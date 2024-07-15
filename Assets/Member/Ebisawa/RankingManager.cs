using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Loading;
using UnityEngine;

public class RankingManager : MonoBehaviour
{
    int[] _ranking;

    void Awake()
    {
        LoadRanking();
    }
  
    public void AddRankingEntry(int score)
    {
        List<int> rankingList = _ranking.ToList();
        rankingList.Add(score);
        SaveRanking(rankingList);
    }
   
    public int[] GetRankingEntries()
    {
        return _ranking;
    }
   
    public void LoadRanking()
    {
        int[] ranking = new int[3];

        for (int i = 0; i < 3; i++)
        {
            ranking[i] = PlayerPrefs.GetInt($"{i}");
        }

        _ranking = ranking;
    }
    
    private void SaveRanking(List<int> ranking)
    {
        ranking.Sort();
        ranking.Reverse();

        for (int i = 0; i < 3 && i < ranking.Count; i++)
        {
            PlayerPrefs.SetInt($"{i}", ranking[i]);
            Debug.Log(ranking[i]);
        }

        PlayerPrefs.Save();

    }

    [Serializable]
    private class RankingList
    {
    }
}
