using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Death : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainScreen");
    }
    public void Retry()
    {
        SceneManager.LoadScene("Game");
    }
}
