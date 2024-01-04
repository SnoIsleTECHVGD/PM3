using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    public KeyCode Heal;
    public GameObject healIcon;
    void Update()
    { 
        if (Input.GetKeyDown(Heal) && healIcon.activeInHierarchy)
        {
            healIcon.SetActive(false);
                Stats mystats = GetComponent<Stats>();
                if (mystats.currentHealth < mystats.maxHealth)
                {
                    mystats.currentHealth = mystats.maxHealth;
                }
        }
    }
}
