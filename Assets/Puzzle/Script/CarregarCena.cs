using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CarregarCena : MonoBehaviour
{

      public void Load(string scene)
    {
        SceneManager.LoadScene(scene);
        if(Time.timeScale == 0){
            Time.timeScale = 1;
        }
    }

      
}
