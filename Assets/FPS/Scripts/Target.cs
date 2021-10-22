using System.Collections;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] float exitTime;
    [SerializeField] Material hitMaterial;

    Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        StartCoroutine("TargetExit");
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Boo")
        {
            renderer.materials = new Material[] { hitMaterial };
        }
    }

    IEnumerator TargetExit()
    {
        yield return new WaitForSeconds(exitTime);
        Destroy(gameObject);
    }
}
