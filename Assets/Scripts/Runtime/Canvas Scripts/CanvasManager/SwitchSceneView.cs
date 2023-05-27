using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSceneView : MonoBehaviour
{

    const string UPDATECITYVIEW1 = "CityView1Canvas";
    const string UPDATECITYVIEW2 = "CityView2Canvas";
    const string UPDATECITYMAP1 = "CanvasMap1";
    const string UPDATECITYMAP2 = "CanvasMap2";

    private GameObject AudioObject;
    private Audio Aud;

    void Start()
    {
        AudioObject = GameObject.Find("AudioManager");
        Aud = AudioObject.GetComponent<Audio>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            updateCanvas(UPDATECITYVIEW1);
            Aud.playCityAudio();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            updateCanvas(UPDATECITYVIEW2);
            Aud.playCityAudio();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            updateCanvas(UPDATECITYMAP1);
            Aud.playBattleAudio();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            updateCanvas(UPDATECITYMAP2);
            Aud.playBattleAudio();
        }
    }


    private void updateCanvas(string sceneCanvasUpdate)
    {
        if(this.gameObject.name == sceneCanvasUpdate)
            {
                setCanvasEnabled();
            }
        else
            {
                setCanvasDisabled();
            }
    }


    private void setCanvasEnabled()
    {
        Canvas sceneCanvas = this.gameObject.GetComponent<Canvas>() as Canvas;
        if(this.gameObject.name == UPDATECITYVIEW1 || this.gameObject.name == UPDATECITYVIEW2)
        {
            sceneCanvas.enabled = true;
            this.gameObject.GetComponent<CityMapClickEvents>().enabled = true;
        }
        if(this.gameObject.name == UPDATECITYMAP1 || this.gameObject.name == UPDATECITYMAP2)
        {
            sceneCanvas.enabled = true;
        }
    }


    private void setCanvasDisabled()
    {
        Canvas sceneCanvas = this.gameObject.GetComponent<Canvas>() as Canvas;
        if(this.gameObject.name == UPDATECITYVIEW1 || this.gameObject.name == UPDATECITYVIEW2)
        {
            sceneCanvas.enabled = false;
            this.gameObject.GetComponent<CityMapClickEvents>().enabled = false;
        }
        if(this.gameObject.name == UPDATECITYMAP1 || this.gameObject.name == UPDATECITYMAP2)
        {
            sceneCanvas.enabled = false;
        }
    }
}
