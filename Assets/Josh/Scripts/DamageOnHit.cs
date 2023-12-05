using UnityEngine;


[RequireComponent(typeof(Stats))]
public class DamageOnHit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Stats ourStats = GetComponent<Stats>();
        Stats hitStats = collision.gameObject.GetComponent<Stats>();
        if (hitStats != null)
        {
            hitStats.health -= ourStats.attack - hitStats.defense;
            if(hitStats.health <= 0)
            {

            }
        }
        
    }
}
