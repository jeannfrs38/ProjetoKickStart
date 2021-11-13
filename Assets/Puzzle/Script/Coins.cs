using UnityEngine;

public class Coins : MonoBehaviour
{
    public bool colidiu;

    ObjectCoin _objectoCoins;

    void Start()
    {
        _objectoCoins = FindObjectOfType(typeof(ObjectCoin)) as ObjectCoin;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _objectoCoins.QtdCoins(10);
            Destroy(this.gameObject);
        }
    }
}
