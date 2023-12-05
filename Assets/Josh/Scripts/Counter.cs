using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; // Don't forget this line
public class Script : MonoBehaviour
{
    
    public int stat;
    public void Update()
    {
        Stats stats = GetComponent<Stats>();
        stats.health = stat;
        stat.ToString();
    }
}
