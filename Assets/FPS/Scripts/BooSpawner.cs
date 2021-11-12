using UnityEngine;

public class BooSpawner : MonoBehaviour
{
    [SerializeField] GameObject booPrefab;
    public int pontuacao;
    [SerializeField] Boo _boo;
    public bool colidiu;
private void Start() {
    _boo = FindObjectOfType(typeof(Boo))as Boo;
    _boo = booPrefab.GetComponent<Boo>();
}
    void Update()
    {
        CheckClick();
       
    }

    void CheckClick()
    {
        if (Input.GetMouseButtonDown(0) && !RoundManager.gameOver)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit) && hit.transform != null)
            {
                Fire(hit.transform.position);
            }
        }
    }

    void Fire(Vector3 position)
    {
        Boo boo = Instantiate(booPrefab).GetComponent<Boo>();
        boo.firePosition = (position - transform.position).normalized * 30;
        AudioManager.audioManagerInstace.PlayAudioSix();
    }


}
