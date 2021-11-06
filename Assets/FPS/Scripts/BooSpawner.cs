using UnityEngine;

public class BooSpawner : MonoBehaviour
{
    [SerializeField] GameObject booPrefab;

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
