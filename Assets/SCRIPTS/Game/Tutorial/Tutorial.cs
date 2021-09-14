using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public enum StatesTutorial { Calibrando, Tutorial, Finalizado }
    public StatesTutorial EstAct = StatesTutorial.Calibrando;
    void Start()
    {
        EstAct = StatesTutorial.Calibrando;
    }

    void Update()
    {
        
    }
}
