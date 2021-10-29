using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControle : MonoBehaviour
{
    public Image panelStarted;
    public bool gameStarted;
    private float secondStart;

    

    void Start()
    {
        panelStarted = GetComponent<Image>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 1){
           StartCoroutine(GameStarted(secondStart));
        }
    }


    IEnumerator GameStarted(float seconds){
        yield return new WaitForSeconds (seconds);
        gameStarted = true;
        Destroy(gameObject);
    }
}
