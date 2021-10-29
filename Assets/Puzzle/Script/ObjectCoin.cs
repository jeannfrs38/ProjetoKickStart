using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCoin : MonoBehaviour

{
    private Coins _coins;
    void Start()
    {
        _coins = FindObjectOfType(typeof(Coins)) as Coins;
    }

  
   
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            _coins.QtdCoins(10);
        }
    }
}
