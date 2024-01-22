using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits : MonoBehaviour
{
    public void Josh()
    {
        SceneManager.LoadScene("Josh");
    }
    public void Clara()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Faustina()
    {
        SceneManager.LoadScene("Faustina");
    }
    public void Collin()
    {
        SceneManager.LoadScene("Collin");
    }
    public void Jasmine()
    {
        SceneManager.LoadScene("Jasmine");
    }
    public void Matthew()
    {
        SceneManager.LoadScene("Matthew");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainScreen");
    }
}
