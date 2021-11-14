using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RoundManager : MonoBehaviour
{
    [HideInInspector]
    public static bool gameOver;

    public GameController _gameController;
    [SerializeField] TargetManager targetManager;
    [SerializeField] Text roundText;
    [SerializeField] Text roundTextGameOver;

    [SerializeField] int targetsPerRound;
    [SerializeField] float delayBetweenRounds;

    BooSpawner _booSpawner;
    int round = 0;

    void Start()
    {
        _booSpawner = FindObjectOfType(typeof(BooSpawner)) as BooSpawner;
        targetManager.onSpawnComplete.AddListener(() => StartCoroutine("WaitForNextRound"));
        StartCoroutine("WaitForNextRound");
        gameOver = false;
    }

    void Update()
    {
        if (gameOver == true)
        {
            _gameController.RoundRecord(round);
        }
    }

    IEnumerator WaitForNextRound()
    {
        if (gameOver) yield return 0;

        round++;
        roundText.text = $"ROUND: {round}";
        roundTextGameOver.text = round.ToString();

        yield return new WaitForSeconds(delayBetweenRounds);
        NextRound();
    }

    void NextRound()
    {
        targetManager.SpawnTargets(targetsPerRound);
    }
}
