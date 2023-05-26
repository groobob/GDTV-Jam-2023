using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AudioManager
{
    private static AudioSource musicSource;
    private static AudioSource sfxSource;
    private static AudioSource voiceSource;
    private static Dictionary<string, AudioClip> voiceActing = new Dictionary<string, AudioClip>();
    private static Dictionary<string, AudioClip> musicTheme = new Dictionary<string, AudioClip>();
    public static AudioSource MusicSource { get => musicSource; set => musicSource = value; }
    public static AudioSource SfxSource { get => sfxSource; set => sfxSource = value; }
    public static AudioSource VoiceSource { set => voiceSource = value; }

    public static Dictionary<string, AudioClip> VoiceActing { get => voiceActing; set => voiceActing = value; }
    public static Dictionary<string, AudioClip> MusicTheme { get => musicTheme; set => musicTheme = value; }

    public static void PlayMusic(string title)
    {
        if(musicTheme.TryGetValue(title, out AudioClip value))
        {
            musicSource.clip = value;
            musicSource.Play();
        }
        else
        {
            Debug.Log("Audio Not Found");
        }
    }

    public static void PlaySfx(AudioClip source)
    {
        sfxSource.clip = source;
        sfxSource.Play();
    }

    public static void PlayVoiceActor(string title)
    {
        if(voiceActing.TryGetValue(title, out AudioClip value))
        {
            voiceSource.clip = value;
            voiceSource.Play();
        }
    }
}
