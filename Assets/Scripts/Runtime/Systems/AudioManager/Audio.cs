using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource musicSource2;
    [SerializeField] private AudioSource sfxSource;
    [SerializeField] private AudioSource voiceSource;

    [SerializeField] private AudioClip mainTheme;
    [SerializeField] private Dictionary<string, AudioClip> voiceActing = new Dictionary<string, AudioClip>();
    [SerializeField] private Dictionary<string, AudioClip> musicTheme = new Dictionary<string, AudioClip>();

    public List<AudioFile> voiceActingScripts = new List<AudioFile>();
    public List<AudioFile> musicThemecripts = new List<AudioFile>();
    public List<AudioFile> soundSFXScripts = new List<AudioFile>();

    private bool audioStop = false;

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

    void Update()
    {
        if(!musicSource.isPlaying && audioStop == false)
        {
            AudioManager.PlayMusic("repeatingintro");
            musicSource.loop = true;
            musicSource.volume = .25f;
        }
    }

    public void placeClips()
    {
        musicSource.clip = musicThemecripts[2].sfx;
        musicSource2.clip = musicThemecripts[3].sfx;

        musicSource.loop = true;
        musicSource.volume = .4f;

        musicSource2.loop = true;
        musicSource2.volume = .5f;

        audioStop = true;

        musicSource.Play();
        musicSource2.Play();

    }
    public void playCityAudio()
    {
        musicSource2.Pause();
        musicSource.UnPause();
    }

    public void playBattleAudio()
    {
        musicSource.Pause();
        musicSource2.UnPause();
    }

    public void playWoodBuild()
    {
        sfxSource.clip = soundSFXScripts[0].sfx;
        sfxSource.volume = .3f;

        sfxSource.Play();
    }

    public void playMetalBuild()
    {
        sfxSource.clip = soundSFXScripts[1].sfx;
        sfxSource.volume = .25f;

        sfxSource.Play();
    }


}

[System.Serializable]
public struct AudioFile
{
    public string title;
    public AudioClip sfx;
}
