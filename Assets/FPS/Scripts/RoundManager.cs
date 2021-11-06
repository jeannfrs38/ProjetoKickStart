using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RoundManager : MonoBehaviour
{
    [SerializeField] TargetManager targetManager;
    [SerializeField] Text roundText;
    [SerializeField] int targetsPerRound;
    [SerializeField] float delayBetweenRounds;

    [HideInInspector]
    public static bool gameOver = false;

    int round = 0;

    void Start()
    {
        targetManager.onSpawnComplete.AddListener(() => StartCoroutine("WaitForNextRound"));
        StartCoroutine("WaitForNextRound");
    }

    IEnumerator WaitForNextRound()
    {
        if (gameOver) yield return 0;

        round++;
        roundText.text = $"ROUND {round}";
        yield return new WaitForSeconds(delayBetweenRounds);
        NextRound();
    }

    void NextRound()
    {
        targetManager.SpawnTargets(targetsPerRound);
    }
}
