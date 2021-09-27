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
        scorePlayer1.text = "Score: " + GameManager.instancia.Player1.Dinero;
        scorePlayer2.text = "Score: " + GameManager.instancia.Player2.Dinero;
    }

    void Update()
    {
        //if(GameManager.Instancia.modo == GameManager.ModoJuego.Multiplayer)
        //{
        //    scorePlayer1.text = "Score: " + GameManager.Instancia.Player1.Dinero;
        //    scorePlayer2.text = "Score: " + GameManager.Instancia.Player2.Dinero;
        //}
        //else
        //{
        //    scorePlayer2.gameObject.SetActive(false);
        //    scorePlayer1.text = "Score: " + GameManager.Instancia.Player1.Dinero;
        //}
    }
}
