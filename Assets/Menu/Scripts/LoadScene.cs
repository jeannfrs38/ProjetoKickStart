using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    Scene cenaCarregada;

    void Update()
    {
        cenaCarregada = SceneManager.GetActiveScene();
    }

    public void Load(string scene)
    {
        AudioManager.audioManagerInstace.PlayAudioFour();
        SceneManager.LoadScene(scene);

        if (Time.timeScale == 0) Time.timeScale = 1;

        if (scene == "Menu")
        {
            if (AudioManager.audioManagerInstace.audioTwo.isPlaying == true)
            {
                AudioManager.audioManagerInstace.StopMusica(AudioManager.audioManagerInstace.audioTwo);
            }
            else if (AudioManager.audioManagerInstace.audioThree.isPlaying == true)
            {
                AudioManager.audioManagerInstace.StopMusica(AudioManager.audioManagerInstace.audioThree);
            }

            AudioManager.audioManagerInstace.PlayAudioOne();
        }

        if (scene == "Puzzle")
        {
            if (AudioManager.audioManagerInstace.audioOne.isPlaying == true)
            {
                AudioManager.audioManagerInstace.StopMusica(AudioManager.audioManagerInstace.audioOne);
            }
            else if (AudioManager.audioManagerInstace.audioThree.isPlaying == true)
            {
                AudioManager.audioManagerInstace.StopMusica(AudioManager.audioManagerInstace.audioThree);
            }

            AudioManager.audioManagerInstace.PlayAudioTwo();
        }

        if (scene == "FPS")
        {
            if (AudioManager.audioManagerInstace.audioOne.isPlaying == true)
            {
                AudioManager.audioManagerInstace.StopMusica(AudioManager.audioManagerInstace.audioOne);
            }
            else if (AudioManager.audioManagerInstace.audioTwo.isPlaying == true)
            {
                AudioManager.audioManagerInstace.StopMusica(AudioManager.audioManagerInstace.audioTwo);
            }

            AudioManager.audioManagerInstace.PlayAudioThree();
        }
    }
}
