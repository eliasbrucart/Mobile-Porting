using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    public GameObject[] buttons;

    void Update()
    {
        if (EventSystem.current.currentSelectedGameObject != null)
            return;
        EventSystem.current.SetSelectedGameObject(buttons[0]);
    }

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
