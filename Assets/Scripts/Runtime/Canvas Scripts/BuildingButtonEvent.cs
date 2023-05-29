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

                FindObjectOfType<ViewManager>().GetComponent<ViewManager>().UnloadScene(GameScenes.buildingUID1);
                FindObjectOfType<ViewManager>().GetComponent<ViewManager>().UnloadScene(GameScenes.buildingUID2);
                
            if(this.gameObject.name == "Canvas2")
                GameObject.Find("CityView1Canvas").SetActive(false);
            if(this.gameObject.name == "Canvas")
                GameObject.Find("CityView2Canvas").SetActive(false);


                Debug.Log("Attempting Purchase");
                if(buildingName == "farm" || buildingName == "house") Aud.playWoodBuild();
                else Aud.playMetalBuild();   

                if (buildingName == "sword")
                {
                    GameObject.Find("GameplayManager").GetComponent<ArmyBuildingScript>().OnWarriorPurchase();
                }
                else if (buildingName == "bow")
                {
                    GameObject.Find("GameplayManager").GetComponent<ArmyBuildingScript>().OnBowPurchase();
                }
                else if (buildingName == "shield")
                {
                   GameObject.Find("GameplayManager").GetComponent<ArmyBuildingScript>().OnDefenderPurchase();
                }

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
