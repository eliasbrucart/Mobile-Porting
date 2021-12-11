using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIGameplay : MonoBehaviour
{
    [SerializeField] private TMP_Text capturedBagsP1;
    [SerializeField] private TMP_Text capturedBagsP2;
    [SerializeField] private TMP_Text timeLeft;
    [SerializeField] private GameObject pausePanel;
    public GameObject buttonsP1;
    public GameObject buttonsP2;

    private GameManager gm;
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        if (gm.modo == GameManager.ModoJuego.Singleplayer)
        {
            capturedBagsP2 = null;
            buttonsP2 = null;
        }
    }

    void Update()
    {
        if(gm.modo == GameManager.ModoJuego.Multiplayer)
        {
            capturedBagsP1.text = "" + gm.Player1.Dinero;
            capturedBagsP2.text = "" + gm.Player2.Dinero;
        }
        else
            capturedBagsP1.text = "" + gm.Player1.Dinero;
        timeLeft.text = "" + gm.TiempoDeJuego.ToString("F0");
    }

    public void ActivateButtons(string player)
    {
        if(player == "P1")
        {
            if (buttonsP1 != null)
                buttonsP1.SetActive(true);
        }
        else
        {
            if (buttonsP2 != null)
                buttonsP2.SetActive(true);
        }
    }

    public void DisableButtons(string player)
    {
        if(player == "P1")
        {
            if (buttonsP1 != null)
                buttonsP1.SetActive(false);
        }
        else
        {
            if (buttonsP2 != null)
                buttonsP2.SetActive(false);
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
}
