using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControls : MonoBehaviour
{
    public void UpOne()
    {
        InputManager.Instance.GetAxis("Vertical_1");
    }
    public void LeftOne()
    {
        InputManager.Instance.GetAxis("Negative Horizontal_1");
    }
    public void RightOne()
    {
        InputManager.Instance.GetAxis("Horizontal_1");
    }

    public void UpTwo()
    {
        InputManager.Instance.GetAxis("Vertical_2");
    }
    public void LeftTwo()
    {
        InputManager.Instance.GetAxis("Negative Horizontal_2");
    }
    public void RightTwo()
    {
        InputManager.Instance.GetAxis("Horizontal_2");
    }
}
