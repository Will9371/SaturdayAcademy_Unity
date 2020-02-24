using System;
using UnityEngine;
using UnityEngine.Events;

public class KeyboardInput : MonoBehaviour
{
    [SerializeField] UnityEvent OnNonePressed;
    [SerializeField] InputInfo_Keyboard[] keyboardInputs;
    bool isIdle;

    private void Update()
    {
        isIdle = true;

        foreach (var input in keyboardInputs)
        {
            foreach (var key in input.keys)
            {
                if (Input.GetKey(key) && input.Press ||
                    Input.GetKeyDown(key) && input.PressDown ||
                    Input.GetKeyUp(key) && input.PressUp)
                {
                    isIdle = false;
                    input.OnPress.Invoke();
                }
            }
        }

        if (isIdle)
            OnNonePressed.Invoke();
    }
}

[Serializable]
public struct InputInfo_Keyboard
{
    public string actionName;
    public KeyCode[] keys;
    public UnityEvent OnPress;
    public bool Press, PressDown, PressUp;
}

