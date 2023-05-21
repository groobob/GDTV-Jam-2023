using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitSettings : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Camera uiCamera;
    private void Awake()
    {
        CamerasManager.UiCamera = uiCamera;
        CamerasManager.MainCamera = mainCamera;
    }
}
