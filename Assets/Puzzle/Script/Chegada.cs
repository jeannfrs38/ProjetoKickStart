using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chegada : MonoBehaviour
{
    public bool colidiuChegada;
    public Scene cenaCarregada;

    CarregarCena _carregarCena;
    GameControle _gameControle;
    ObjectCoin _objectCoin;

    void Start()
    {
        _gameControle = FindObjectOfType(typeof(GameControle)) as GameControle;
        _carregarCena = FindObjectOfType(typeof(CarregarCena)) as CarregarCena;
        _objectCoin = FindObjectOfType(typeof(ObjectCoin)) as ObjectCoin;
    }

    void Update()
    {
        cenaCarregada = SceneManager.GetActiveScene();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            colidiuChegada = true;
            _gameControle.gameStarted = false;
            _objectCoin.CoinsUpdate(_objectCoin.coins);
            AudioManager.audioManagerInstace.PlayAudioFive();

            if (cenaCarregada.buildIndex == 2)
            {
                StartCoroutine(ChamarFase(10f, 4));
            }
            else if (cenaCarregada.buildIndex == 4)
            {
                StartCoroutine(ChamarFase(10f, 5));
            }
            else if (cenaCarregada.buildIndex == 5)
            {
                StartCoroutine(ChamarFase(10f, 6));
            }
        }
    }

    IEnumerator ChamarFase(float seconds, int cena)
    {
        yield return new WaitForSeconds(seconds);

        SceneManager.LoadScene(cena);
        _gameControle.gameStarted = true;
    }
}
