using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIJoystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    [SerializeField] RectTransform stick;
    [SerializeField] Image background;
    [SerializeField] string playerInputX;
    [SerializeField] string playerInputY;
    [SerializeField] Color color;
    public float joystickLimit;

    Vector2 ConvertToLocalPos(PointerEventData eventData)
    {
        Vector2 newPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(transform as RectTransform, eventData.position, eventData.enterEventCamera, out newPos);
        return newPos;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 stickPos = ConvertToLocalPos(eventData);
        if (stickPos.magnitude > joystickLimit)
        {
            stickPos = stickPos.normalized * joystickLimit;
        }
        if (stick != null)
            stick.anchoredPosition = stickPos;

        float x = stickPos.x / joystickLimit;
        float y = stickPos.y / joystickLimit;

        InputManager.Instance.SetAxis(playerInputX, x);
        InputManager.Instance.SetAxis(playerInputY, y);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (stick != null && background != null)
        {
            background.color = Color.gray;
            stick.anchoredPosition = Vector2.zero;
        }
        InputManager.Instance.SetAxis(playerInputX, 0);
        InputManager.Instance.SetAxis(playerInputY, 0);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (stick != null && background != null)
        {
            background.color = color;
            stick.anchoredPosition = ConvertToLocalPos(eventData);
        }
    }

    void OnDisable()
    {
        InputManager.Instance.SetAxis(playerInputX, 0);
        InputManager.Instance.SetAxis(playerInputY, 0);
    }
}