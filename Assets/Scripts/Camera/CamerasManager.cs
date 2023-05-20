using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasManager
{
    private static Camera mainCamera;
    private static Camera uiCamera;

    public static Camera MainCamera { get => mainCamera; set => mainCamera = value; }
    public static Camera UiCamera { get => uiCamera; set => uiCamera = value; }
}
