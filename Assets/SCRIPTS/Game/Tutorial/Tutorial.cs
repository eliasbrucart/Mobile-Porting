using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public enum GameMode
    {
        Singleplayer,
        Multiplayer
    }
    public enum SelectedInput
    {
        WASD,
        Arrows
    }
    public SelectedInput selectedInput;
    public enum StatesTutorial { Calibrando, Tutorial, Finalizado }
    public StatesTutorial EstAct = StatesTutorial.Calibrando;
    public GameMode actualMode;
    void Start()
    {
        EstAct = StatesTutorial.Calibrando;
    }

    void Update()
    {
        TutorialInput();
    }

    private void TutorialInput()
    {
        if(selectedInput == SelectedInput.Arrows || actualMode == GameMode.Singleplayer)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.UpArrow))
                EstAct = StatesTutorial.Tutorial;
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                EstAct = StatesTutorial.Finalizado;
                CheckTutorialFinish();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.W))
                EstAct = StatesTutorial.Tutorial;
            if (Input.GetKeyDown(KeyCode.D))
            {
                EstAct = StatesTutorial.Finalizado;
                CheckTutorialFinish();
            }
        }
    }

    private void CheckTutorialFinish()
    {
        if (EstAct == StatesTutorial.Finalizado && actualMode == GameMode.Multiplayer)
            SceneManager.LoadScene("Gameplay multiplayer");
        else if (EstAct == StatesTutorial.Finalizado && actualMode == GameMode.Singleplayer)
            SceneManager.LoadScene("Gameplay singleplayer");
        //chequear que tutorial termino para darle velocidad al camion correspondiente
    }
}
