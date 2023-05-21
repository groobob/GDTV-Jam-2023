using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingDataSettings : MonoBehaviour
{
    [SerializeField] private List<BuildingsData> buildingData = new List<BuildingsData>();
    [SerializeField] private static Dictionary<string, BuildingsData> data = new Dictionary<string, BuildingsData>();

    public static Dictionary<string, BuildingsData> Data { get => data; }

    private void Awake()
    {
        foreach(var item in buildingData)
        {
            data.Add(item.buildingName, item);
        }
    }
}

[System.Serializable]
public struct BuildingsData
{
    public string buildingName;
    public int buildingCost;
    public Sprite buildingGraphics;
}
