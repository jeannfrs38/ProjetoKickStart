using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    public Text roundRecordText;
    public int roundRecord;
    public static int pontuacao;

    void Start()
    {
        roundRecord = PlayerPrefs.GetInt("Round", 0);
        roundRecordText.text = "Round Record: " + roundRecord.ToString();
    }

    void Update()
    {
        Debug.Log(pontuacao);
    }

    public static void AdicionarPontos(int qtdpntos)
    {
        pontuacao += qtdpntos;

    }

    public void Score()
    {
        scoreText.text = pontuacao.ToString();

    }
    public void RoundRecord(int round)
    {
        if (roundRecord < round)
        {
            roundRecord = round;
            PlayerPrefs.SetInt("Round", roundRecord);
            roundRecordText.text = "Round Record: " + roundRecord.ToString();

        }
    }
}
