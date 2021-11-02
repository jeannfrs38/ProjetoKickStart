using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CarregarCena : MonoBehaviour
{
    private Scene cenaCarregada;

    private void Update() {
        cenaCarregada = SceneManager.GetActiveScene();
        
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

           
    }
      public void Load(string scene)
    {
         
        AudioManager.audioManagerInstace.PlayAudioFour();
        SceneManager.LoadScene(scene);
        if(Time.timeScale == 0){
            Time.timeScale = 1;
        }
    }

      
}
