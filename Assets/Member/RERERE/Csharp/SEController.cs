using System.Collections.Generic;
using UnityEngine;

public class SEController : MonoBehaviour
{
    //�X�^�e�B�b�N�ϐ�
    private static SEController _instance = default;
    public static SEController Instance => _instance;

    //�������w��
    [SerializeField] private AudioClip[] _sounds = default;
    //�I�[�f�B�I�\�[�X�w��
    private AudioSource _audioSource = default;

    //�X�^�[�g����Ɏ��s
    private void Awake()
    {
        //�V���O���g��
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
        //�I�[�f�B�I�\�[�X�擾
        _audioSource = GetComponent<AudioSource>();

       
    }

    public void RunSE(AudioClip audioClip)
    {

        _audioSource.PlayOneShot(audioClip);
    }

}