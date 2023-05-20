using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ViewManager : MonoBehaviour
{
    [Tooltip("Only Use For Init Game Scene On Game Start")]
    [SerializeField] private List<GameScenes> gameSceneInit = new List<GameScenes>();


    void Start()
    {
        GameSceneInit();
    }

    public void GameSceneInit()
    {
        foreach (var gameScenes in gameSceneInit)
        {
            SceneManager.LoadScene(gameScenes.ToString(), LoadSceneMode.Additive);
        }
    }

    public void LoadScene(GameScenes sceneName)
    {
        SceneManager.LoadScene(sceneName.ToString(), LoadSceneMode.Additive);
    }

    public void UnloadScene(GameScenes sceneName)
    {
        SceneManager.LoadScene(sceneName.ToString(), LoadSceneMode.Additive);
    }
}

public enum GameScenes
{
    menu,
    cityView,
    resourceUI,
    cityBuildingUI,
}
