using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSesame : MonoBehaviour
{
    public KeyCode Open;
    public GameObject keyIcon;
    public GameObject Door;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Door") && keyIcon.activeInHierarchy)
        {
            Door.SetActive(false);
            keyIcon.SetActive(false);
        }
    }
}
