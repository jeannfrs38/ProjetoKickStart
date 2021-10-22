using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Target : MonoBehaviour
{
    [HideInInspector]
    public UnityEvent onExit;

    [SerializeField] float exitTime;
    [SerializeField] Material hitMaterial;

    Renderer ren;

    void Start()
    {
        ren = GetComponent<Renderer>();
        StartCoroutine("TargetExit");
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Boo")
        {
            ren.materials = new Material[] { hitMaterial };
        }
    }

    IEnumerator TargetExit()
    {
        yield return new WaitForSeconds(exitTime);
        onExit.Invoke();
        Destroy(gameObject);
    }
}
