using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Teste : MonoBehaviour
{
    public Text textTotal;
    public int totalCoins;
    private ObjectCoin _objectoCoin;
    void Start(){
        _objectoCoin =  FindObjectOfType(typeof(ObjectCoin)) as ObjectCoin;

        totalCoins = PlayerPrefs.GetInt("totalcoins", totalCoins);
        textTotal.text = totalCoins.ToString();
    }




    
        
}
