using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class TargetManager : MonoBehaviour
{
    [SerializeField] Vector2 spawnArea;
    [SerializeField] float spawnSpeed;
    [SerializeField] GameObject targetPrefab;

    bool gameOver;
    int targetsOnScreen;
    Vector3 targetSize;

    public UnityEvent onSpawnComplete;

    void Start()
    {
        targetSize = targetPrefab.GetComponent<Renderer>().bounds.size;
    }

    public void SpawnTargets(int targets)
    {
        StartCoroutine(SpawnLoop(targets));
    }

    IEnumerator SpawnLoop(int targets)
    {
        targetsOnScreen = targets;
        int spawnedTargets = 0;

        while (spawnedTargets < targets && !RoundManager.gameOver)
        {
            GameObject target = Instantiate(targetPrefab, RandomPosition(), targetPrefab.transform.rotation, transform);
            target.GetComponent<Target>().onExit.AddListener(() =>
            {
                --targetsOnScreen;
                if (targetsOnScreen <= 0) onSpawnComplete.Invoke();
            });
            spawnedTargets++;
            yield return new WaitForSeconds(spawnSpeed);
        }
    }

    Vector3 RandomPosition()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(-spawnArea.x, spawnArea.x),
            Random.Range(-spawnArea.y, spawnArea.y),
            transform.position.z
        );
        bool hit = Physics.CheckBox(randomPosition, targetSize / 2);

        while (hit)
        {
            randomPosition = new Vector3(
                Random.Range(-spawnArea.x, spawnArea.x),
                Random.Range(-spawnArea.y, spawnArea.y),
                transform.position.z
            );
            hit = Physics.CheckBox(randomPosition, targetSize / 2);
        }

        return randomPosition;
    }
}
