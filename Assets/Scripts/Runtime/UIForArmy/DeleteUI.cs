using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteUI : MonoBehaviour
{
    public void DeleteThisUI()
    {
        FindObjectOfType<ViewManager>().GetComponent<ViewManager>().UnloadScene(GameScenes.ArmyUIScene1);
    }
}
