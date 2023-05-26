using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayManager : MonoBehaviour
{
    public List<string> loadGameplayScenes = new List<string>();

    private static GameObject cityView1Canvas;
    private static GameObject cityView2Canvas;
    private static GameObject cityMap1Canvas;
    private static GameObject cityMap2Canvas;

    public static GameObject CityView1Canvas { get => cityView1Canvas; set => cityView1Canvas = value; }
    public static GameObject CityView2Canvas { get => cityView2Canvas; set => cityView2Canvas = value; }
    public static GameObject CityMap1Canvas { get => cityMap1Canvas; set => cityMap1Canvas = value; }
    public static GameObject CityMap2Canvas { get => cityMap2Canvas; set => cityMap2Canvas = value; }
    

    private void Awake()
    {
        foreach (var item in loadGameplayScenes)
        {
            SceneManager.LoadSceneAsync(item, LoadSceneMode.Additive);
        }
    }

    private void Start()
    {

    }

    private void Update()
    {

    }
}
