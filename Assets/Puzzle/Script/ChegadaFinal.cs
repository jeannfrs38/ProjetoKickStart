using System.Collections;
using UnityEngine;

public class ChegadaFinal : MonoBehaviour
{
    public GameObject MenuWin;
    Chegada _chegada;

    void Start()
    {
        _chegada = FindObjectOfType(typeof(Chegada)) as Chegada;
    }

    void Update()
    {
        if (_chegada.cenaCarregada.buildIndex == 6 && _chegada.colidiuChegada == true)
        {
            StartCoroutine(ChamarFinal(10f));
        }
        else
        {
            MenuWin.SetActive(false);
        }
    }

    IEnumerator ChamarFinal(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        MenuWin.SetActive(true);
    }
}
