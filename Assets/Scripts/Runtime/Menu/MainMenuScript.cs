using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    private bool gameStarted = false;
    public GameObject button1;
    public GameObject button2;
    public GameObject pressAnyKey;
    private Vector2 presskeyInitialPos = new Vector2(0, -450);
    private Vector2 presskeySecondPos = new Vector2(0, -250);
    private UITransition uiTransition;
    
    [SerializeField] float currentTime;
    [SerializeField] private GameObject AudioObject;
    [SerializeField] private Audio Aud;

    void Start()
    {
        uiTransition = GetComponent<UITransition>();
        StartCoroutine(pressKeyGui());
    }
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
        currentTime -= Time.deltaTime;
        if (Input.anyKeyDown && currentTime < 0)
        {
            if (gameStarted == false)
            {
                gameStarted = true;
                button1.SetActive(true);
                button2.SetActive(true);
                StartCoroutine(fadeOutPressKey());
            }
        }
    }

    IEnumerator pressKeyGui()
    {
        pressAnyKey.transform.localPosition = presskeyInitialPos;
        yield return new WaitForSeconds(0.7f);
        pressAnyKey.transform.LeanMoveLocal(presskeySecondPos, 1).setEaseOutQuad();
        uiTransition.fadeInText(pressAnyKey, 0.8f);
    }

    IEnumerator fadeOutPressKey()
    {
        uiTransition.fadeOutText(pressAnyKey, 0.6f);
        yield return new WaitForSeconds(0.7f);
        pressAnyKey.SetActive(false);
    }
}
