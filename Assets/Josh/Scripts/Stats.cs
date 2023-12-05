using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int health;
    public int attack;
    public int defense;

    public GameObject loseText;
    private void Update()
    {
        if(health <= 0)
        {
            if (loseText)
            {
                loseText.SetActive(true);
            }
            gameObject.SetActive(false);
        }
    }
}