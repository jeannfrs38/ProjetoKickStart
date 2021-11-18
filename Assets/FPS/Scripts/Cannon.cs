using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] GameObject booPrefab;
    [SerializeField] float velProjetil;
    [SerializeField] Transform cannonSpawner;
    [SerializeField] Transform spawnPoint;

    void Update()
    {
        InputManager();
    }

    void InputManager()
    {
        if (Input.GetMouseButtonDown(0) && !RoundManager.gameOver)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit) && hit.transform != null)
            {
                Fire(hit.point);
            }
        }
    }

    void Fire(Vector3 position)
    {
        cannonSpawner.LookAt(position);
        Boo boo = Instantiate(booPrefab, spawnPoint.position, Quaternion.identity).GetComponent<Boo>();
        boo.firePosition = (position - spawnPoint.position).normalized * velProjetil;
        AudioManager.audioManagerInstace.PlayAudioSix();
    }
}
