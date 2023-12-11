using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Stats))]
public class DamageOnHit : MonoBehaviour
{
    public GameObject loseText;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Stats ourStats = GetComponent<Stats>();
        Stats hitStats = collision.gameObject.GetComponent<Stats>();

        if (hitStats != null)
        {
            hitStats.health -= ourStats.attack - hitStats.defense;

            if (ourStats.health <= 0)
            {
                if (loseText)
                {
                    loseText.SetActive(true);
                }
                gameObject.SetActive(false);
            }
        }
        
    }
}