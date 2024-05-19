using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMan1 : MonoBehaviour
{
    private void Awake()
    {
        showCursor(false);
    }

    public static void showCursor(bool cursorMode)
    {
        if (cursorMode)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        Cursor.visible = cursorMode;
    }
}
