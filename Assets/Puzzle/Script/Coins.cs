using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    
    private ObjectCoin _objectoCoins;
    
    public  bool colidiu;
    void Start()
    {
        _objectoCoins = FindObjectOfType(typeof(ObjectCoin))as ObjectCoin;
    }

     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            _objectoCoins.QtdCoins(10);
            Destroy(this.gameObject);

            
        }
    }


}
