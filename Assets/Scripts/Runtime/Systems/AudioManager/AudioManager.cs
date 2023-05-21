using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AudioManager
{
    private static AudioSource musicSource;
    private static AudioSource sfxSource;
    public static AudioSource MusicSource { get => musicSource; set => musicSource = value; }
    public static AudioSource SfxSource { get => sfxSource; set => sfxSource = value; }

    public static void PlayMusic(AudioClip source)
    {
        musicSource.clip = source;
        musicSource.Play();
    }

    public static void PlaySfx(AudioClip source)
    {
        sfxSource.clip = source;
        sfxSource.Play();
    }


}
