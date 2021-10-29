using UnityEngine;

public class Boo : MonoBehaviour
{
    [HideInInspector]
    public Vector3 firePosition;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = firePosition;
    }

    void OnCollisionEnter(Collision other) {
        rb.useGravity = true;
        
    }
    
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
