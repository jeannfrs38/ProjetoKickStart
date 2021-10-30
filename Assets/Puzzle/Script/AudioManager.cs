using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AudioManager : MonoBehaviour
{
    
    public static AudioManager audioManagerInstace;
    public AudioSource audioOne;
    public AudioSource audioTwo;
    public AudioSource audioThree;
    public AudioSource audioFour;
    public AudioSource audioFive;


    public float fadeTime;
    public Slider sliderMusica;
    public Slider sliderEfeito;
    public float volume;
    public float volumeEf;
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


    private void Update()
    {
        Debug.Log(volume);
    }

    public void PlayAudioOne()
    {

            audioOne.Play();
           
 
        
    }
    public void PlayAudioThree()
    {

            audioThree.Play();
           

    }
    public void PlayAudioFour()
    {

            audioFour.Play();
           

    }
    public void PlayAudioFive()
    {

        audioFive.Play();


    }

    public void PlayAudioTwo()
    {
        
        if (audioTwo.isPlaying == false )
        {
            
            audioTwo.Play();
            audioTwo.volume = 0;
            
            StartCoroutine(FadeIn(audioTwo, fadeTime, volume));

        }

    }
    public void StopMusica()
    {
        StartCoroutine(FadeOut(audioTwo, fadeTime));
        volume = audioTwo.volume;
    }



    public static IEnumerator FadeIn(AudioSource audiosource, float FadeTime, float volume)
    {
        while(audiosource.volume < volume){
            audiosource.volume += 0.1f * Time.deltaTime / FadeTime;

            yield return null;
        }
    }

    public static IEnumerator FadeOut(AudioSource audiosource, float FadeOut)
    {
        while(audiosource.volume > 0.01f)
        {
            audiosource.volume -= 0.5f * Time.deltaTime / FadeOut;
            yield return null;
        }
        audiosource.Stop();
    }



}
