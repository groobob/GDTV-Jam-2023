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
            SceneManager.LoadSceneAsync(gameScenes.ToString(), LoadSceneMode.Additive);
        }
    }

    public void LoadScene(GameScenes sceneName)
    {
        if (SceneManager.GetSceneByName(sceneName.ToString()).isLoaded) return;
        SceneManager.LoadSceneAsync(sceneName.ToString(), LoadSceneMode.Additive);
    }

    public void UnloadScene(GameScenes sceneName)
    {
        if (!(SceneManager.GetSceneByName(sceneName.ToString()).isLoaded)) return;
        SceneManager.UnloadSceneAsync(sceneName.ToString());
    }
}

public enum GameScenes
{
    menu,
    pause,
    cityViewD1,
    cityViewD2,
    cityMapD1,
    cityMapD2,
    resourceUI,
    buildingUID1,
    buildingUID2,
    GameplayManager,
    MiniMapUI,
    ArmyUIScene1,
}
