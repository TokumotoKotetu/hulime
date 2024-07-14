using System.Collections.Generic;
using UnityEngine;

public class SEController : MonoBehaviour
{
    //スタティック変数
    private static SEController _instance = default;
    public static SEController Instance => _instance;

    //音源を指定
    [SerializeField] private AudioClip[] _sounds = default;
    //オーディオソース指定
    private AudioSource _audioSource = default;

    //スタートより先に実行
    private void Awake()
    {
        //シングルトン
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        //オーディオソース取得
        _audioSource = GetComponent<AudioSource>();

       
    }

    public void RunSE(AudioClip audioClip)
    {

        _audioSource.PlayOneShot(audioClip);
    }

}