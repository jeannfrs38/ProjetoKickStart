using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectCoin : MonoBehaviour

{
    private int coins;
    public Text textCoins;
    private Coins _coins;
    public  GameObject loserImage;

    void Start()
    {

            _coins = FindObjectOfType(typeof(Coins)) as Coins;
            
            textCoins.text = coins.ToString();

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
    }
     

    IEnumerator ChamarLoser(float seconds){
        yield return new WaitForSeconds(seconds);
          
        loserImage.SetActive(true);
            Destroy(gameObject);
    }


}
