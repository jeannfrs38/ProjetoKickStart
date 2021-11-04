using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    public Text textTotalCoins;
    private int totalCoins;

    void Start()
    {   
        if(instance == null){
            instance = this;
             DontDestroyOnLoad(this.gameObject);
        }else{
           Destroy(gameObject);
        }

        totalCoins =  PlayerPrefs.GetInt("totalcoins" , 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CoinsUpdate(int coins){

        if(coins > 0){
        totalCoins += coins;
        
        textTotalCoins.text = totalCoins.ToString();
        PlayerPrefs.SetInt("totalcoins", totalCoins);

        }
    }
}
