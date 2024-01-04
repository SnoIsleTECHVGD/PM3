using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    public KeyCode Heal;
    public GameObject he;
    void Update()
    { 
        if (Input.GetKeyDown(Heal) && he.activeInHierarchy)
        {
            he.SetActive(false);
                Stats mystats = GetComponent<Stats>();
                if (mystats.currentHealth < mystats.maxHealth)
                {
                    mystats.currentHealth = mystats.maxHealth;
                }
        }
    }
}
