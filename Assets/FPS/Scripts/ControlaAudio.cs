using UnityEngine;

public class ControlaAudio : MonoBehaviour
{
    private AudioSource MeuAudioSource;
    public static AudioSource instancia;

    void Start()
    {
        MeuAudioSource = GetComponent<AudioSource>();
        instancia = MeuAudioSource;
    }
}
