using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingUIRemove : MonoBehaviour
{
    // Update is called once per frame
    void LateUpdate()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            Debug.Log("Removing UI");
            FindObjectOfType<ViewManager>().GetComponent<ViewManager>().UnloadScene(GameScenes.buildingUID2);
            GameObject.Find("CanvasActivator1").transform.GetChild(0).gameObject.SetActive(true);
            GameObject.Find("CanvasActivator2").transform.GetChild(0).gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            Debug.Log("Removing UI");
            FindObjectOfType<ViewManager>().GetComponent<ViewManager>().UnloadScene(GameScenes.buildingUID1);
            GameObject.Find("CanvasActivator1").transform.GetChild(0).gameObject.SetActive(true);
            GameObject.Find("CanvasActivator2").transform.GetChild(0).gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            Debug.Log("Removing UI");
            FindObjectOfType<ViewManager>().GetComponent<ViewManager>().UnloadScene(GameScenes.buildingUID1);
            FindObjectOfType<ViewManager>().GetComponent<ViewManager>().UnloadScene(GameScenes.buildingUID2);
            GameObject.Find("CanvasActivator1").transform.GetChild(0).gameObject.SetActive(true);
            GameObject.Find("CanvasActivator2").transform.GetChild(0).gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            Debug.Log("Removing UI");
            FindObjectOfType<ViewManager>().GetComponent<ViewManager>().UnloadScene(GameScenes.buildingUID1);
            FindObjectOfType<ViewManager>().GetComponent<ViewManager>().UnloadScene(GameScenes.buildingUID2);
            GameObject.Find("CanvasActivator1").transform.GetChild(0).gameObject.SetActive(true);
            GameObject.Find("CanvasActivator2").transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}