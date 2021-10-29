using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    
    public Text textCoins;
    private int coins;
    void Start()
    {
        textCoins.text =  coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QtdCoins(int qtdcoins){

        coins += qtdcoins;
        textCoins.text = coins.ToString();
    }


}
