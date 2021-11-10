using System.Collections;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager audioManagerInstace;
    public AudioSource audioOne;
    public AudioSource audioTwo;
    public AudioSource audioThree;
    public AudioSource audioFour;
    public AudioSource audioFive;
    public AudioSource audioSix;
    public AudioSource audioSeven;

    public float fadeTime;
    public float volume;

    void Awake()
    {
        if (audioManagerInstace == null)
        {
            audioManagerInstace = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayAudioOne()
    {
        if (audioOne.isPlaying == false)
        {
            audioOne.Play();
            StartCoroutine(FadeIn(audioOne, fadeTime, volume));
        }
    }

    public void PlayAudioThree()
    {
        if (audioThree.isPlaying == false)
        {
            audioThree.Play();
            StartCoroutine(FadeIn(audioThree, fadeTime, volume));
        }
    }

    public void PlayAudioFour()
    {
        audioFour.Play();
    }

    public void PlayAudioFive()
    {
        audioFive.Play();
    }

    public void PlayAudioSix()
    {
        audioSix.Play();
    }

    public void PlayAudioSeven()
    {
        audioSeven.Play();
    }

    public void PlayAudioTwo()
    {
        if (audioTwo.isPlaying == false)
        {
            audioTwo.Play();
            StartCoroutine(FadeIn(audioTwo, fadeTime, volume));
        }
    }

    public void StopMusica(AudioSource audioSoucer)
    {
        StartCoroutine(FadeOut(audioSoucer, fadeTime));
        volume = audioSoucer.volume;
    }

    public static IEnumerator FadeIn(AudioSource audiosource, float FadeTime, float volume)
    {
        while (audiosource.volume < volume)
        {
            audiosource.volume += 0.1f * Time.deltaTime / FadeTime;

            yield return null;
        }
    }

    public static IEnumerator FadeOut(AudioSource audiosource, float FadeOut)
    {
        while (audiosource.volume > 0.01f)
        {
            audiosource.volume -= 0.5f * Time.deltaTime / FadeOut;
            yield return null;
        }
        audiosource.Stop();
    }
}
