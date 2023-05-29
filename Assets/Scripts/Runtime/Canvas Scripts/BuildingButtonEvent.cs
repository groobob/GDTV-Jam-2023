using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingButtonEvent : MonoBehaviour
{
    public static event OnBuildingPurchaseEvent OnBuildingPurchaseAttempt;
    public delegate void OnBuildingPurchaseEvent(BuildingsData buildingData);


    private GameObject AudioObject;
    private Audio Aud;

    void Awake()
    {
        AudioObject = GameObject.Find("AudioManager");
        Aud = AudioObject.GetComponent<Audio>();
    }

    public void PurchaseBuildingAttempt(string buildingName)
    {
        Debug.Log("Function Ran");
        if(BuildingDataSettings.Data.TryGetValue(buildingName, out BuildingsData data))
        {
            Debug.Log("Found Building Data " + buildingName);
            if(ResourceManager.Resources.gold >= data.buildingCost)
            {
                
            if(this.gameObject.name == "Canvas2")
                GameObject.Find("CityView1Canvas").SetActive(false);
            if(this.gameObject.name == "Canvas")
                GameObject.Find("CityView2Canvas").SetActive(false);


                Debug.Log("Attempting Purchase");
                if(buildingName == "farm" || buildingName == "house") Aud.playWoodBuild();
                else Aud.playMetalBuild();   


                OnBuildingPurchaseAttempt?.Invoke(data);
            }

            
        }
        else
        {
            GameObject.Find("CanvasActivator1").transform.GetChild(0).gameObject.SetActive(true);
            GameObject.Find("CanvasActivator2").transform.GetChild(0).gameObject.SetActive(true);
            Debug.Log("Could Not Get Building Data");
        }
    }
}
