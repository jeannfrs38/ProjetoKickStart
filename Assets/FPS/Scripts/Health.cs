using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private int vidaMaxima = 5;
    public int vidaAtual;
    public Image boo1;
    public Image boo2;
    public Image boo3;
    public Image boo4;
    public Image boo5;
    void Start()
    {
        vidaAtual = vidaMaxima;
    }

    public void ReceberDano()
    {
        vidaAtual --;
        
        if(vidaAtual == 4)
        {
            boo5.gameObject.SetActive(false);
        }
        else if (vidaAtual == 3)
        {   
            boo5.gameObject.SetActive(false);
            boo4.gameObject.SetActive(false);
        }
        else if (vidaAtual == 2)
        {   
            boo5.gameObject.SetActive(false);
            boo4.gameObject.SetActive(false);
            boo3.gameObject.SetActive(false);
        }
        else if (vidaAtual == 1)
        {   
            boo5.gameObject.SetActive(false);
            boo4.gameObject.SetActive(false);
            boo3.gameObject.SetActive(false);
            boo2.gameObject.SetActive(false);
        }
        else if (vidaAtual == 0)
        {   
            boo5.gameObject.SetActive(false);
            boo4.gameObject.SetActive(false);
            boo3.gameObject.SetActive(false);
            boo2.gameObject.SetActive(false);
            boo1.gameObject.SetActive(false);
        }
    }
     
    
    
}
