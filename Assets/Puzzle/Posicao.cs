using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posicao : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.x >= 1.77f){
            transform.position = new Vector3(1.77f, transform.position.y, transform.position.z);
        }else if (transform.position.x <= -1.807f){
            transform.position = new Vector3(-1.807f, transform.position.y, transform.position.z);     
        }
        
        if( transform.position.z <=-1.74f){
            transform.position = new Vector3(transform.position.x, transform.position.y, -1.74f); 
        }else if( transform.position.z >= 1.761f){
            transform.position = new Vector3(transform.position.x, transform.position.y, 1.761f); 
        }
        
        
    }
}
