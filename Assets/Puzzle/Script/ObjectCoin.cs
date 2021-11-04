using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectCoin : MonoBehaviour

{
    public int coins;
    public Text textCoins;
    public Text textCoinsLoser;

    public Text textCoinsTotal;
    public int totalCoins;
    private Coins _coins;
    public  GameObject loserImage;

    void Start()
    {
            
            _coins = FindObjectOfType(typeof(Coins)) as Coins;
            
            textCoins.text = coins.ToString();
            textCoinsLoser.text = coins.ToString();
            textCoinsTotal.text = coins.ToString();
            totalCoins =  PlayerPrefs.GetInt("totalcoins", totalCoins);
    }

    private void Update() {
        if(transform.position.y <=  0){

            
            StartCoroutine(ChamarLoser(0.2f));
            AudioManager.audioManagerInstace.PlayAudioSeven(); 
            
        
        }

        else{
            loserImage.SetActive(false);
        }
     
    }
     public void QtdCoins(int qtdcoins){

        coins += qtdcoins;
        textCoins.text = coins.ToString();
        textCoinsLoser.text = textCoins.text;
        
    
        

        
    }
     

    IEnumerator ChamarLoser(float seconds){
        yield return new WaitForSeconds(seconds);
          
        loserImage.SetActive(true);
            Destroy(gameObject);
            CoinsUpdate(coins);
    }

     public void CoinsUpdate(int coins){
         if(coins < totalCoins){
             totalCoins += coins;
        
            textCoinsTotal.text = totalCoins.ToString();
            PlayerPrefs.SetInt("totalcoins", totalCoins);
            
         }
        

    }


}
