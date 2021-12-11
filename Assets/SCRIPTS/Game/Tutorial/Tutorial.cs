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
            if (InputManager.Instance.GetAxis("Horizontal_1") > 0 && InputManager.Instance.GetAxis("Vertical_1") > 0)
                EstAct = StatesTutorial.Tutorial;
            if (InputManager.Instance.GetAxis("Horizontal_1") < 0)
            {
                EstAct = StatesTutorial.Finalizado;
                CheckTutorialFinish();
            }
        }
        else
        {
            if (InputManager.Instance.GetAxis("Horizontal_2") > 0 && InputManager.Instance.GetAxis("Vertical_2") > 0)
                EstAct = StatesTutorial.Tutorial;
            if (InputManager.Instance.GetAxis("Horizontal_2") < 0)
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
