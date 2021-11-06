using UnityEngine;

public class ControlaAudio : MonoBehaviour
{
    public static AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
}
