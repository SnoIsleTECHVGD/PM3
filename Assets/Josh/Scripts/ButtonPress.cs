using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public KeyCode one;
    public KeyCode two;
    public KeyCode three;
    public KeyCode none;
    public GameObject dot1;
    public GameObject dot2;
    public GameObject dot3;
    public GameObject dot4;


    void Update()
    {
       if(Input.GetKeyDown(one))
        {
            dot1.SetActive(true);
            dot2.SetActive(false);
            dot3.SetActive(false);
            
        }

       if(Input.GetKeyDown(two))
        {
            dot1.SetActive(false);
            dot2.SetActive(true);
            dot3.SetActive(false);
            
        }

        if (Input.GetKeyDown(three))
        {
            dot1.SetActive(false);
            dot2.SetActive(false);
            dot3.SetActive(true);
            
        }
        if (Input.GetKeyDown(none))
        {
            dot1.SetActive(false);
            dot2.SetActive(false);
            dot3.SetActive(false);

        }
    }
}
