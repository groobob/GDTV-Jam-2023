using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingCanvasControl : MonoBehaviour
{

    private Canvas sceneCanvas;
    private string whatCanvasUpdate;
    // Start is called before the first frame update
    void Awake()
    {
        sceneCanvas = this.gameObject.GetComponent<Canvas>() as Canvas;
        if(this.gameObject.name == "CityView1Canvas")
        {
            sceneCanvas.enabled = true;
            this.gameObject.GetComponent<CityMapClickEvents>().enabled = true;
        }
    }


}
