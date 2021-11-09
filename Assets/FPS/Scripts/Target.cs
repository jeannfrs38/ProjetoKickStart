using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Target : MonoBehaviour
{
    [HideInInspector]
    public UnityEvent onExit;

    [SerializeField] float exitTime;
    [SerializeField] Material hitMaterial;
    private Health scriptHealth;
    Renderer ren;

    void Start()
    {
        ren = GetComponent<Renderer>();
        scriptHealth = GameObject.FindObjectOfType(typeof(Health)) as Health;
        StartCoroutine("TargetExit");
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            ren.materials[1] = hitMaterial;
            scriptHealth.ReceberVida();
            Destroy(other.gameObject, 0.5f);
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
