using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasEvent : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button creditButton;
    [SerializeField]private Button settingButton;


    public void Start()
    {
        GetComponent<Canvas>().worldCamera = GameObject.FindWithTag("UICamera").GetComponent<Camera>();

        playButton.onClick.AddListener(() => { 
            PlayGame(); 
        });

        creditButton.onClick.AddListener(() => {
            ShowCredits();
        });

        settingButton.onClick.AddListener(() => {
            ShowSettings();
        });
    }

    public void PlayGame()
    {
        Debug.Log("Play Game Scene");
        FindObjectOfType<ViewManager>().GetComponent<ViewManager>().LoadScene(GameScenes.cityViewD1);
        FindObjectOfType<ViewManager>().GetComponent<ViewManager>().LoadScene(GameScenes.resourceUI);
        FindObjectOfType<ViewManager>().GetComponent<ViewManager>().UnloadScene(GameScenes.menu);
    }

    public void ShowCredits()
    {
        Debug.Log("Show Credits");
    }

    public void ShowSettings()
    {
        Debug.Log("Show Settings");
    }
}
