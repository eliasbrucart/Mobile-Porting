using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIGameplay : MonoBehaviour
{
    [SerializeField] private TMP_Text capturedBagsP1;
    [SerializeField] private TMP_Text capturedBagsP2;
    //public List<Button> uiButtonListP1 = new List<Button>();
    //public List<Button> uiButtonListP2 = new List<Button>();
    public GameObject buttonsP1;
    public GameObject buttonsP2;

    private GameManager gm;
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        capturedBagsP1.text = "" + gm.Player1.Dinero;
        capturedBagsP2.text = "" + gm.Player2.Dinero;
    }

    public void ActivateButtons(string player)
    {
        if(player == "P1")
        {
            //for (int i = 0; i < uiButtonListP1.Count; i++)
            //    if (uiButtonListP1[i] != null)
            //        uiButtonListP1[i].gameObject.SetActive(true);
            if (buttonsP1 != null)
                buttonsP1.SetActive(true);
        }
        else
        {
            //for (int i = 0; i < uiButtonListP2.Count; i++)
            //    if (uiButtonListP2[i] != null)
            //        uiButtonListP2[i].gameObject.SetActive(true);
            if (buttonsP2 != null)
                buttonsP2.SetActive(true);
        }
    }

    public void DisableButtons(string player)
    {
        if(player == "P1")
        {
            //for (int i = 0; i < uiButtonListP1.Count; i++)
            //    if (uiButtonListP1[i] != null)
            //        uiButtonListP1[i].gameObject.SetActive(false);
            if (buttonsP1 != null)
                buttonsP1.SetActive(false);
        }
        else
        {
            //for (int i = 0; i < uiButtonListP2.Count; i++)
            //    if (uiButtonListP2[i] != null)
            //        uiButtonListP2[i].gameObject.SetActive(false);
            if (buttonsP2 != null)
                buttonsP2.SetActive(false);
        }
    }
}
