using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewChangeScript : MonoBehaviour
{
    ViewManager viewManager;
    void Start()
    {
        viewManager = FindObjectOfType<ViewManager>().GetComponent<ViewManager>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            viewManager.LoadScene(GameScenes.cityViewD1);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            viewManager.LoadScene(GameScenes.cityMapD1);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            viewManager.LoadScene(GameScenes.cityViewD2);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            viewManager.LoadScene(GameScenes.cityMapD2);
        }
    }
}
