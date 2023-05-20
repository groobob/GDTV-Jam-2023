using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    private bool gameStarted = false;
    public GameObject button1;
    public GameObject button2;
    [SerializeField] float currentTime;
    public void PlayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void Update()
    {
        currentTime -= Time.deltaTime;
        if (Input.anyKeyDown && currentTime < 0)
        {
            if (gameStarted == false)
            {
                gameStarted = true;
                button1.SetActive(true);
                button2.SetActive(true);
            }
        }
    }
}
