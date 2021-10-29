using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Target : MonoBehaviour
{
    [HideInInspector]
    public UnityEvent onExit;

    [SerializeField] float exitTime;
    [SerializeField] Material hitMaterial;
    public Health scriptHealth;
    Renderer ren;

    void Start()
    {
        ren = GetComponent<Renderer>();
         scriptHealth = GameObject.FindObjectOfType(typeof(Health)) as Health;
        StartCoroutine("TargetExit");
    }

   
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player")
        {
            
            ren.materials = new Material[] { hitMaterial };
            
            
        }
        
    }
    IEnumerator TargetExit()
    {
        yield return new WaitForSeconds(exitTime);
        onExit.Invoke();
        Destroy(gameObject);
        scriptHealth.ReceberDano();
        
    }
}
