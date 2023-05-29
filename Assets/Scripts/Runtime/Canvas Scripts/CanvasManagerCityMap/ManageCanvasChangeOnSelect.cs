using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageCanvasChangeOnSelect : MonoBehaviour
{
    public void stopSceneChange()
    {
        SwitchSceneView temp;
        EditUICanvas temp2;
        BuildingUIRemove temp3;
        temp = GameObject.Find("CanvasMap1").GetComponent<SwitchSceneView>();
        temp.enabled = false;


        temp = GameObject.Find("CanvasMap2").GetComponent<SwitchSceneView>();
        temp.enabled = false;


        temp = GameObject.Find("CityView1Canvas").GetComponent<SwitchSceneView>();
        temp.enabled = false;


        temp = GameObject.Find("CityView2Canvas").GetComponent<SwitchSceneView>();
        temp.enabled = false;

        temp2 = GameObject.Find("Canvas").GetComponent<EditUICanvas>();
        temp2.enabled = false;

        temp3 = GameObject.Find("GameplayManager").GetComponent<BuildingUIRemove>();
        temp3.enabled = false;
    }

    public void startSceneChange()
    {
        SwitchSceneView temp;
        EditUICanvas temp2;
        BuildingUIRemove temp3;

        temp = GameObject.Find("CanvasMap1").GetComponent<SwitchSceneView>();
        temp.enabled = true;


        temp = GameObject.Find("CanvasMap2").GetComponent<SwitchSceneView>();
        temp.enabled = true;


        temp = GameObject.Find("CityView1Canvas").GetComponent<SwitchSceneView>();
        temp.enabled = true;


        temp = GameObject.Find("CityView2Canvas").GetComponent<SwitchSceneView>();
        temp.enabled = true;

        temp2 = GameObject.Find("Canvas").GetComponent<EditUICanvas>();
        temp2.enabled = true;

        temp3 = GameObject.Find("GameplayManager").GetComponent<BuildingUIRemove>();
        temp3.enabled = true;
    }
}
