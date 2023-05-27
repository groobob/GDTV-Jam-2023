using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    private bool gameStarted = false;
    public GameObject button1;
    public GameObject button2;

    [SerializeField] private GameObject AudioObject;
    [SerializeField] private Audio Aud;


    public void PlayButton()
    {
        AudioObject = GameObject.Find("AudioManager");
        Aud = AudioObject.GetComponent<Audio>();
        Aud.placeClips();
        Aud.playCityAudio();
        FindObjectOfType<ViewManager>().GetComponent<ViewManager>().LoadScene(GameScenes.GameplayManager);
        FindObjectOfType<ViewManager>().GetComponent<ViewManager>().LoadScene(GameScenes.resourceUI);
        FindObjectOfType<ViewManager>().GetComponent<ViewManager>().LoadScene(GameScenes.MiniMapUI);
        FindObjectOfType<ViewManager>().GetComponent<ViewManager>().UnloadScene(GameScenes.menu);
    }
    void Update()
    {
        if (gameStarted == false)
        {
            gameStarted = true;
            button1.SetActive(true);
            button2.SetActive(true);
        }
    }
}
