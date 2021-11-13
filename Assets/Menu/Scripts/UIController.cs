using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    public Text textTotalCoins;

    int totalCoins;
    ObjectCoin _objectoCoin;

    void Start()
    {
        _objectoCoin = FindObjectOfType(typeof(ObjectCoin)) as ObjectCoin;
    }

    public void CoinsUpdate(int coins)
    {
        if (coins < totalCoins)
        {
            totalCoins += coins;

            textTotalCoins.text = totalCoins.ToString();
            PlayerPrefs.SetInt("totalcoins", totalCoins);
        }
    }
}
