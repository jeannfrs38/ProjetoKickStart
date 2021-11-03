using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChegadaFinal : MonoBehaviour
{
    public GameObject MenuWin;
    private Chegada _chegada;
    void Start()
    {
        _chegada = FindObjectOfType(typeof(Chegada)) as Chegada;
    }

    // Update is called once per frame
    void Update()
    {
        if(_chegada.cenaCarregada.buildIndex == 6 && _chegada.colidiuChegada == true){

            
            StartCoroutine(ChamarFinal(10f));
            

        }
        else{
            MenuWin.SetActive(false);
        }
    }

     IEnumerator ChamarFinal(float seconds){
        yield return new WaitForSeconds(seconds);
            MenuWin.SetActive(true);
            
        
    }
}
