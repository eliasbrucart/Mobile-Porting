using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{

    static public ScenesManager instanceScenesManager;
    static public ScenesManager Instance { get { return instanceScenesManager; } }

    private void Awake()
    {
        if (instanceScenesManager != this && instanceScenesManager != null)
            Destroy(this.gameObject);
        else
            instanceScenesManager = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void OnClickQuit()
    {
        Application.Quit();
    }
}
