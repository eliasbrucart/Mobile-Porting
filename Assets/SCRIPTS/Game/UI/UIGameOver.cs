using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIGameOver : MonoBehaviour
{
    public TMP_Text scorePlayer1;
    public TMP_Text scorePlayer2;

    void Start()
    {
        if (GameManager.instancia.modo == GameManager.ModoJuego.Multiplayer)
        {
            scorePlayer1.text = "Score: " + GameManager.instancia.Player1.Dinero;
            scorePlayer2.text = "Score: " + GameManager.instancia.Player2.Dinero;
        }
        else if(GameManager.instancia.modo == GameManager.ModoJuego.Singleplayer)
        {
            scorePlayer2.gameObject.SetActive(false);
            scorePlayer1.text = "Score: " + GameManager.instancia.Player1.Dinero;
        }
    }
}
