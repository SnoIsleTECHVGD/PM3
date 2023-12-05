
using UnityEngine;

public class DamageOnButton : MonoBehaviour
{
    public KeyCode RightSwing;
    public KeyCode LeftSwing;
    private void Update()
    {
        Stats pStats = GetComponent<Stats>();
        if (Input.GetKeyDown(RightSwing))
        {
            pStats.attack += pStats.attack + pStats.attack;

        }
        if (Input.GetKeyDown(LeftSwing))
        {
            pStats.defense += pStats.defense + pStats.attack;
        }
    }

}
    

