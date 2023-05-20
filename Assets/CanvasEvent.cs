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
