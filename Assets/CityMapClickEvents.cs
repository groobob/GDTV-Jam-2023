using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityMapClickEvents : MonoBehaviour
{
    public Button mapButton;
    public List<Button> plotButtons = new List<Button>();
    public bool isDemension1;
    public bool buildingUIEnabled;
    private void Start()
    {
        mapButton.onClick.AddListener(() => {
            if (buildingUIEnabled)
            {
                FindObjectOfType<ViewManager>().GetComponent<ViewManager>().UnloadScene(GameScenes.buildingUID1);
                buildingUIEnabled = false;
            }        
        });

        foreach(var button in plotButtons)
        {
            button.onClick.AddListener(() => {
                if (isDemension1)
                {
                    FindObjectOfType<ViewManager>().GetComponent<ViewManager>().LoadScene(GameScenes.buildingUID1);
                    buildingUIEnabled = true;
                }
                else
                {
                    FindObjectOfType<ViewManager>().GetComponent<ViewManager>().LoadScene(GameScenes.buildingUID2);
                    buildingUIEnabled = true;
                } 
            });
        }
    }
}
