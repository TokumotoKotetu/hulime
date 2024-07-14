using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseItem : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayerIncreaseController PlayerIncreaseController;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        for (int i = 0; i < 3; i++)
        {
           PlayerIncreaseController.Increase();
        }
    }
}
