using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignCanvas : MonoBehaviour
{
    public GameObject canvas; //Made private to make it easier to assign when passing through github
    public TargetCanvas targetCanvas;

    private void Start()
    {

        switch (targetCanvas)
        {
            case TargetCanvas.cityview1:
                GameplayManager.CityView1Canvas = canvas;
                Debug.Log(GameplayManager.CityView1Canvas.name);
                break;
            case TargetCanvas.cityview2:
                GameplayManager.CityView2Canvas = canvas;
                Debug.Log(GameplayManager.CityView2Canvas.name);
                break;
            case TargetCanvas.citymap1:
                GameplayManager.CityMap1Canvas = canvas;
                Debug.Log(GameplayManager.CityMap1Canvas.name);
                break;
            case TargetCanvas.citymap2:
                GameplayManager.CityMap2Canvas = canvas;
                Debug.Log(GameplayManager.CityMap2Canvas.name);
                break;
        }
    }
}

public enum TargetCanvas
{
    cityview1,
    cityview2,
    citymap1,
    citymap2
}
