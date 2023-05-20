using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource sfxSource;

    [SerializeField] private AudioClip mainTheme;
    private void Awake()
    {
        AudioManager.MusicSource = musicSource;
        AudioManager.SfxSource = sfxSource;
    }

    // Start is called before the first frame update
    void Start()
    {
        AudioManager.PlayMusic(mainTheme);
    }
}
