using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameReset : MonoBehaviour
{
    public void GameIsReset()
    {
        FindObjectOfType<ViewManager>().GetComponent<ViewManager>().LoadScene(GameScenes.menu);
        GameObject.Find("InitManager").GetComponent<ResourceManager>().RestartRes();
        FindObjectOfType<ViewManager>().GetComponent<ViewManager>().UnloadScene(GameScenes.GameOver);
    }
}
