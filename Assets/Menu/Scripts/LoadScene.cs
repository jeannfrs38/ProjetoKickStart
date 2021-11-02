using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private Scene cenaCarregada;
    private void Update() {
       cenaCarregada = SceneManager.GetActiveScene();
    }
    public void Load(string scene)
    {

        AudioManager.audioManagerInstace.PlayAudioFour();
        SceneManager.LoadScene(scene);
        
        if(Time.timeScale == 0){
            Time.timeScale = 1;

       
             
       

             
         }if(scene == "Menu"){
             AudioManager.audioManagerInstace.PlayAudioOne();
         }if(scene ==  "Puzzle"){
             AudioManager.audioManagerInstace.StopMusica( AudioManager.audioManagerInstace.audioOne);
              AudioManager.audioManagerInstace.PlayAudioTwo();
         }if(scene == "FPS"){
             AudioManager.audioManagerInstace.StopMusica( AudioManager.audioManagerInstace.audioOne);
              AudioManager.audioManagerInstace.PlayAudioThree();
         }
    }
}
