using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSetup : MonoBehaviour
{
    [SerializeField] private Canvas canvas;

    private void Awake()
    {
        canvas = gameObject.GetComponent<Canvas>();
        if (canvas.worldCamera != null) Destroy(canvas.worldCamera.gameObject);
        canvas.worldCamera = CamerasManager.UiCamera;
    }
}