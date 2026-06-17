using UnityEngine.InputSystem;
using Holylib.DebugConsole;
using UnityEngine;

public class HolyDebugConsoleExample : MonoBehaviour
{
    private void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        if (Mouse.current.backButton.wasPressedThisFrame) 
        {
            HolyDebugConsole.instance.ToggleConsole();
        }
    }
}
