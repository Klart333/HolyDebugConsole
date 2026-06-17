using UnityEngine;
using UnityEngine.InputSystem;
using Holylib.DebugConsole;
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

public static class DebugGroupStyles {
    
    public const string SaveSytem = "Save System 💾";
    [DebugCommandGroup(SaveSytem)] public static readonly DebugGroupStyle SaveSystemStyle 
        = new DebugGroupStyle("Save System", new Color(0.39f, 0.35f, 0.58f));
    
    public const string Time = "Time ⏰";
    [DebugCommandGroup(Time)] public static readonly DebugGroupStyle TimeStyle 
        = new DebugGroupStyle("Time", new Color(1f, 0.21f, 0.29f));
}
