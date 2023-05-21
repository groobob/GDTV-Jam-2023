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

    public List<VoiceActing> voiceActingScripts = new List<VoiceActing>();
    private void Awake()
    {
        AudioManager.MusicSource = musicSource;
        AudioManager.SfxSource = sfxSource;
        AudioManager.VoiceSource = voiceSource;

        foreach(var item in voiceActingScripts)
        {
            voiceActing.Add(item.title, item.sfx);
        }

        AudioManager.VoiceActing = voiceActing;
    }

    // Start is called before the first frame update
    void Start()
    {
        AudioManager.PlayMusic(mainTheme);
    }
}

[System.Serializable]
public struct VoiceActing
{
    public string title;
    public AudioClip sfx;
}
