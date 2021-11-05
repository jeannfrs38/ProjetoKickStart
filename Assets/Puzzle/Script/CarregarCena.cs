using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CarregarCena : MonoBehaviour
{
    private Scene cenaCarregada;
    private Chegada _chegada;
    private void Start() {
        
    }
    private void Update() {
        cenaCarregada = SceneManager.GetActiveScene();
             _chegada = FindObjectOfType(typeof(Chegada))as Chegada;
    }
    public void ChamarCenaAtual(){
        string cena;
         
          if(cenaCarregada.buildIndex == 2 ){
                cena = "Puzzle";
                Load(cena);
            }else if(cenaCarregada.buildIndex == 4){
                cena ="Puzzle 1";
                Load(cena);
            }else if(cenaCarregada.buildIndex == 5){
                cena ="Puzzle 2";
                Load(cena);
            }else if(cenaCarregada.buildIndex == 6){
               
                cena ="Puzzle 3";
                Load(cena);
            }
            else if(cenaCarregada.buildIndex == 6 && _chegada.colidiuChegada == true){
               
                cena ="Menu";
                Load(cena);
            }

           
    }
      public void Load(string scene)
    {
        
        AudioManager.audioManagerInstace.PlayAudioFour();
        SceneManager.LoadScene(scene);
        if(Time.timeScale == 0){
            Time.timeScale = 1;
        }

        if(scene == "Menu"){
            if(AudioManager.audioManagerInstace.audioTwo.isPlaying == true){
                AudioManager.audioManagerInstace.StopMusica( AudioManager.audioManagerInstace.audioTwo);
            }else if(AudioManager.audioManagerInstace.audioThree.isPlaying == true){
                AudioManager.audioManagerInstace.StopMusica( AudioManager.audioManagerInstace.audioThree);
            }
            AudioManager.audioManagerInstace.PlayAudioOne();
        }if(scene ==  "Puzzle"){
            if(AudioManager.audioManagerInstace.audioOne.isPlaying == true){
                AudioManager.audioManagerInstace.StopMusica( AudioManager.audioManagerInstace.audioOne);
            }else if(AudioManager.audioManagerInstace.audioThree.isPlaying == true){
                AudioManager.audioManagerInstace.StopMusica( AudioManager.audioManagerInstace.audioThree);
            }
            
            AudioManager.audioManagerInstace.PlayAudioTwo();
        }if(scene == "FPS"){
            if(AudioManager.audioManagerInstace.audioOne.isPlaying == true){
                AudioManager.audioManagerInstace.StopMusica( AudioManager.audioManagerInstace.audioOne);
            }else if(AudioManager.audioManagerInstace.audioTwo.isPlaying == true){
                AudioManager.audioManagerInstace.StopMusica( AudioManager.audioManagerInstace.audioTwo);
            }
             
            AudioManager.audioManagerInstace.PlayAudioThree();
        }
    }

      
}
