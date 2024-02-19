using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanDraw : MonoBehaviour
{
    public static CanDraw instance;

    bool isMouseOverUI;

    private void Awake()
    {
        instance = this;
    }

    public bool IsHoveringOverUI() {
        return isMouseOverUI;
    }

    public void MouseEnterUI() {
        isMouseOverUI = true;
    }

    public void MouseExitUI() {
        isMouseOverUI = false;
    }
}
