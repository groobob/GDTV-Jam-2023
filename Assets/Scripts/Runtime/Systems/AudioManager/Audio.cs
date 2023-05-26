using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource sfxSource;
    [SerializeField] private AudioSource voiceSource;

    [SerializeField] private AudioClip mainTheme;
    [SerializeField] private Dictionary<string, AudioClip> voiceActing = new Dictionary<string, AudioClip>();
    [SerializeField] private Dictionary<string, AudioClip> musicTheme = new Dictionary<string, AudioClip>();

    public List<AudioFile> voiceActingScripts = new List<AudioFile>();
    public List<AudioFile> musicThemecripts = new List<AudioFile>();
    private void Awake()
    {
        AudioManager.MusicSource = musicSource;
        AudioManager.SfxSource = sfxSource;
        AudioManager.VoiceSource = voiceSource;

        foreach(var item in voiceActingScripts)
        {
            voiceActing.Add(item.title, item.sfx);
        }

        foreach (var item in musicThemecripts)
        {
            musicTheme.Add(item.title, item.sfx);
        }

        AudioManager.VoiceActing = voiceActing;
        AudioManager.MusicTheme = musicTheme;
    }

    // Start is called before the first frame update
    void Start()
    {
        AudioManager.PlayMusic("intro");
    }
}

[System.Serializable]
public struct AudioFile
{
    public string title;
    public AudioClip sfx;
}
