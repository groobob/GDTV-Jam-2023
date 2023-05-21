using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingButtonEvent : MonoBehaviour
{
    public static event OnBuildingPurchaseEvent OnBuildingPurchaseAttempt;
    public delegate void OnBuildingPurchaseEvent(BuildingsData buildingData);

    public void PurchaseBuildingAttempt(string buildingName)
    {
        Debug.Log("Function Ran");
        if(BuildingDataSettings.Data.TryGetValue(buildingName, out BuildingsData data))
        {
            Debug.Log("Found Building Data");
            if(ResourceManager.Resources.gold >= data.buildingCost)
            {
                Debug.Log("Attempting Purchase");
                OnBuildingPurchaseAttempt?.Invoke(data);
            }
        }
        else
        {
            Debug.Log("Could Not Get Building Data");
        }
    }
}
