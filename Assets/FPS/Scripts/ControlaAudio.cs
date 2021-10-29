using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaAudio : MonoBehaviour
{
   private AudioSource MeuAudioSource;
    public static AudioSource instancia;

    void Awake()
    {
        MeuAudioSource = GetComponent<AudioSource>();
        instancia = MeuAudioSource;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
