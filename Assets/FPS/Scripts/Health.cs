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
            boo5.gameObject.SetActive(false);
        }
        else if (vidaAtual == 3)
        {
            boo5.gameObject.SetActive(false);
            boo4.gameObject.SetActive(false);
        }
        else if (vidaAtual == 2)
        {
            boo5.gameObject.SetActive(false);
            boo4.gameObject.SetActive(false);
            boo3.gameObject.SetActive(false);
        }
        else if (vidaAtual == 1)
        {
            boo5.gameObject.SetActive(false);
            boo4.gameObject.SetActive(false);
            boo3.gameObject.SetActive(false);
            boo2.gameObject.SetActive(false);
        }
        else if (vidaAtual == 0)
        {
            boo5.gameObject.SetActive(false);
            boo4.gameObject.SetActive(false);
            boo3.gameObject.SetActive(false);
            boo2.gameObject.SetActive(false);
            boo1.gameObject.SetActive(false);
            PainelGameOver.gameObject.SetActive(true);
            ControlaAudio.audioSource.clip = SomDeDerrota;
            _gamecontroller.Score();
            ControlaAudio.audioSource.Play();
            RoundManager.gameOver = true;
        }
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
