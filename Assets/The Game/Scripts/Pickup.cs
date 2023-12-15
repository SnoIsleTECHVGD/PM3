using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private bool pickUpAllowed;
    private bool Allowed;
    public KeyCode keycode;
    public GameObject healIcon;
    public GameObject heals;
    public GameObject keyIcon;
    public GameObject key;
    private void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(keycode))
        {
            PickUp();
        }
        if (Allowed && Input.GetKeyDown(keycode))
        {
            Allows();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("heals"))
        {
            pickUpAllowed = true;
        }
        if (collision.gameObject.name.Equals("key"))
        {
            Allowed = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("heals"))
        {
            pickUpAllowed = false;
        }
        if (collision.gameObject.name.Equals("key"))
        {
            Allowed = false;
        }
    }
    private void PickUp()
    {
            heals.SetActive(false);
            healIcon.SetActive(true);
    }
    private void Allows()
    {
        key.SetActive(false);
        keyIcon.SetActive(true);
    }
}
