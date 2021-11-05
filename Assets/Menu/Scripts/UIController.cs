using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    public Text textTotalCoins;
    private int totalCoins;
 
     private ObjectCoin _objectoCoin;

    void Start()
    {   
        

        _objectoCoin =  FindObjectOfType(typeof(ObjectCoin)) as ObjectCoin;

        
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void CoinsUpdate(int coins){

        if(coins < totalCoins){
        totalCoins += coins;
        
        textTotalCoins.text = totalCoins.ToString();
        PlayerPrefs.SetInt("totalcoins", totalCoins);

        }
    }
}
