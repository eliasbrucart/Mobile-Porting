using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControls : MonoBehaviour
{
    public void UpOne()
    {
        InputManager.Instance.SetAxis("Vertical_1", 1);
    }
    public void LeftOne()
    {
        InputManager.Instance.SetAxis("Horizontal_1", -1);
    }
    public void RightOne()
    {
        InputManager.Instance.SetAxis("Horizontal_1", 1);
    }

    public void UpTwo()
    {
        InputManager.Instance.SetAxis("Vertical_2", 1);
    }
    public void LeftTwo()
    {
        InputManager.Instance.SetAxis("Horizontal_2", -1);
    }
    public void RightTwo()
    {
        InputManager.Instance.SetAxis("Horizontal_2", 1);
    }
}
