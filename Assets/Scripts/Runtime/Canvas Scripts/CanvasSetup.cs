using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSetup : MonoBehaviour
{
    [SerializeField] private Canvas canvas;

    private void Awake()
    {
        canvas = gameObject.GetComponent<Canvas>();
        canvas.worldCamera = CamerasManager.UiCamera;
    }
}
