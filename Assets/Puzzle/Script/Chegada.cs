using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Chegada : MonoBehaviour
{
    private CarregarCena _carregarCena;
    public bool colidiuChegada;

    private GameControle _gameControle;
    
    public Scene cenaCarregada;
   
   private ObjectCoin _objectCoin;
   

   private void Start() {
       
       _gameControle = FindObjectOfType(typeof(GameControle)) as GameControle;
       _carregarCena = FindObjectOfType(typeof(CarregarCena))as CarregarCena ;
       _objectCoin = FindObjectOfType(typeof(ObjectCoin))as ObjectCoin;
    }   
   private void Update() {
        cenaCarregada = SceneManager.GetActiveScene();
        
      
   }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            colidiuChegada = true;
            _gameControle.gameStarted = false;
           _objectCoin.CoinsUpdate(_objectCoin.coins);
            AudioManager.audioManagerInstace.PlayAudioFive();
            
            if(cenaCarregada.buildIndex == 2 ){
                StartCoroutine(ChamarFase(10f , 4));
            }else if(cenaCarregada.buildIndex == 4){
                StartCoroutine(ChamarFase(10f , 5));
            }else if(cenaCarregada.buildIndex == 5){
                StartCoroutine(ChamarFase(10f , 6));
            }

        }
    }
    IEnumerator ChamarFase(float seconds , int cena){
        yield return new WaitForSeconds(seconds);
       
        SceneManager.LoadScene(cena);
        _gameControle.gameStarted = true;
    }

   
}
