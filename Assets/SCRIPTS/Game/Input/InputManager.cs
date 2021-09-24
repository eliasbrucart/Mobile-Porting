using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    static public InputManager instanceInputManager;

    static public InputManager Instance { get { return instanceInputManager; } }

    private void Awake()
    {
        if (instanceInputManager != null && instanceInputManager != this)
            Destroy(this.gameObject);
        else
            instanceInputManager = this;
    }

    Dictionary<string, float> axisValues = new Dictionary<string, float>()
    {
        {"Horizontal_1", 0f},{"Vertical_1", 0f}, {"Horizontal_2", 0f}, {"Vertical_2", 0f}
    };

    public void SetAxis(string axis, float value)
    {
        axisValues[axis] = value;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
