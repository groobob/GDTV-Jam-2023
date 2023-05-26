using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverListener : MonoBehaviour
{
    public Canvas GameoverCanvas;

    private void OnEnable()
    {
        ResourceManager.OnEmptyHealth += ResourceManager_OnEmptyHealth;
    }

    private void ResourceManager_OnEmptyHealth()
    {
        GameoverCanvas = GameObject.FindGameObjectWithTag("GameOver").GetComponent<Canvas>();
        GameoverCanvas.enabled = true;
    }
}
