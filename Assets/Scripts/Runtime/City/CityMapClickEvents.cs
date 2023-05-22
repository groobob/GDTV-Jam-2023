using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityMapClickEvents : MonoBehaviour
{
    public static event OnBuildingBoughtEvent OnBuildingBought;
    public static event OnBuildingPlotChangeEvent OnPlotChange;

    public delegate void OnBuildingBoughtEvent(int gold);
    public delegate void OnBuildingPlotChangeEvent(Sprite plot, BuildingType type);

    public Button mapButton;
    public List<Button> plotButtons = new List<Button>();
    public bool isDemension1;
    public bool buildingUIEnabled;

    [Header("Plot Selection")]
    [SerializeField] private GameObject currentPlot;

    public GameObject CurrentPlot { get => currentPlot; }

    private void OnEnable()
    {
        BuildingButtonEvent.OnBuildingPurchaseAttempt += BuildingButtonEvent_OnBuildingPurchaseAttempt;
    }

    private void OnDisable()
    {
        BuildingButtonEvent.OnBuildingPurchaseAttempt -= BuildingButtonEvent_OnBuildingPurchaseAttempt;
    }

    private void BuildingButtonEvent_OnBuildingPurchaseAttempt(BuildingsData buildingData)
    {
        Debug.Log($"{buildingData.buildingName} was purchased on landPlot {currentPlot.name} for {buildingData.buildingCost}");
        currentPlot.GetComponent<Button>().interactable = false;

        OnPlotChange?.Invoke(buildingData.buildingGraphics, buildingData.buildingType);
        OnBuildingBought?.Invoke(buildingData.buildingCost);
    }

    private void Start()
    {
        mapButton.onClick.AddListener(() => {
            if (buildingUIEnabled)
            {
                Debug.Log("Removing UI");
                FindObjectOfType<ViewManager>().GetComponent<ViewManager>().UnloadScene(GameScenes.buildingUID1);
                currentPlot = null;
                buildingUIEnabled = false;
            }        
        });

        foreach(var button in plotButtons)
        {
            button.onClick.AddListener(() => {
                if (isDemension1)
                {
                    FindObjectOfType<ViewManager>().GetComponent<ViewManager>().LoadScene(GameScenes.buildingUID1);
                    currentPlot = button.gameObject;
                    buildingUIEnabled = true;
                }
                else
                {
                    FindObjectOfType<ViewManager>().GetComponent<ViewManager>().LoadScene(GameScenes.buildingUID2);
                    currentPlot = button.gameObject;
                    buildingUIEnabled = true;
                } 
            });
        }
    }
}
