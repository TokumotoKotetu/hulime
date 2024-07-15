using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEButtlon : MonoBehaviour
{
    public void PlayButtonSE(AudioClip clip)
    {
        SEController.Instance.RunSE(clip);
    }
}
