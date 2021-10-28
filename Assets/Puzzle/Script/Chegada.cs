using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Chegada : MonoBehaviour
{
    private CarregarCena _carregarCena;
    public GameObject MenuWin;
    private Scene cenaCarregada;
   
   
   private void Awake() {
       StartCoroutine(DetectarObjetos(0.0001f));
   }
   private void Start() {
       
       
       _carregarCena = FindObjectOfType(typeof(CarregarCena))as CarregarCena ;
       

   }
   private void Update() {
        cenaCarregada = SceneManager.GetActiveScene();
        
      
   }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            
            if(cenaCarregada.buildIndex == 1 ){
                StartCoroutine(ChamarFase(0.5f , 3));
            }else if(cenaCarregada.buildIndex == 3){
                StartCoroutine(ChamarFase(0.5f , 4));
            }else if(cenaCarregada.buildIndex == 4){
                StartCoroutine(ChamarFase(0.5f , 5));
            }else if(cenaCarregada.buildIndex == 5){
               
                MenuWin.SetActive(true);
                Time.timeScale =0 ;
            }
            

        }
    }
    IEnumerator ChamarFase(float seconds , int cena){
        yield return new WaitForSeconds(seconds);
        
        SceneManager.LoadScene(cena);
    }

    IEnumerator DetectarObjetos(float seconds){
        yield return new WaitForSeconds(seconds);
        
        MenuWin.SetActive(false);
        
    }
}
