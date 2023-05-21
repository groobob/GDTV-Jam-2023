using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    private bool gameStarted = false;
    public GameObject button1;
    public GameObject button2;
    public void PlayButton()
    {
        FindObjectOfType<ViewManager>().GetComponent<ViewManager>().UnloadScene(GameScenes.menu);
        FindObjectOfType<ViewManager>().GetComponent<ViewManager>().LoadScene(GameScenes.cityViewD1);
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
