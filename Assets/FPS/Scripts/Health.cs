using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int vidaAtual;
    public Image boo1;
    public Image boo2;
    public Image boo3;
    public Image boo4;
    public Image boo5;
    public GameObject PainelGameOver;
    public AudioClip SomDeDerrota;

    public GameController _gamecontroller;
    int vidaMaxima = 5;

    void Start()
    {
        vidaAtual = vidaMaxima;
    }

    public void ReceberDano()
    {
        vidaAtual--;

        if (vidaAtual == 4)
        {
            boo5.enabled = false;
        }
        else if (vidaAtual == 3)
        {
            boo5.enabled = false;
            boo4.enabled = false;
        }
        else if (vidaAtual == 2)
        {
            boo5.enabled = false;
            boo4.enabled = false;
            boo3.enabled = false;
        }
        else if (vidaAtual == 1)
        {
            boo5.enabled = false;
            boo4.enabled = false;
            boo3.enabled = false;
            boo2.enabled = false;
        }
        else if (vidaAtual == 0)
        {
            boo5.enabled = false;
            boo4.enabled = false;
            boo3.enabled = false;
            boo2.enabled = false;
            boo1.enabled = false;
            GameOver();
        }
    }

    void GameOver()
    {
        PainelGameOver.gameObject.SetActive(true);
        ControlaAudio.audioSource.clip = SomDeDerrota;
        _gamecontroller.Score();
        ControlaAudio.audioSource.Play();
        RoundManager.gameOver = true;
    }

    public void ReceberVida()
    {
        vidaAtual++;
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene("FPS");
    }
}
