using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0){
            Touch t = Input.GetTouch(0);
            if(t.phase == TouchPhase.Moved){
                Vector3 rot = new Vector3(t.deltaPosition.y, 0, t.deltaPosition.x * -1  );
                transform.Rotate( rot * 2 * Time.deltaTime,Space.World );
            }
        }
    }
}
