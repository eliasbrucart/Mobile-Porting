using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void BtnPressed()
    {
        Debug.Log("Button pressed!");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
