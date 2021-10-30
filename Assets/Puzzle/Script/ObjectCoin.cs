using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectCoin : MonoBehaviour

{
    private int coins;
    public Text textCoins;
    private Coins _coins;
    void Start()
    {
        
            _coins = FindObjectOfType(typeof(Coins)) as Coins;
            
            textCoins.text = coins.ToString();

    }


     public void QtdCoins(int qtdcoins){

        coins += qtdcoins;
        textCoins.text = coins.ToString();
    }
}
