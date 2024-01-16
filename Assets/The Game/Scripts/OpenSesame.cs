using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OpenSesame : MonoBehaviour
{
    public GameObject trash;
    public GameObject keyIcon;
    public GameObject Door;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Door") && keyIcon.activeInHierarchy)
        {
            trash.SetActive(false);
            Door.SetActive(false);
            keyIcon.SetActive(false);
            SceneManager.LoadScene("Credits");
        }
    }
}
