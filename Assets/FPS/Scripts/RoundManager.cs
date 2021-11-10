using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RoundManager : MonoBehaviour
{
    [SerializeField] TargetManager targetManager;
    [SerializeField] Text roundText;
    [SerializeField] Text roundTextGameOver;
    [SerializeField] Text scoreText;
    [SerializeField] int targetsPerRound;
    [SerializeField] float delayBetweenRounds;
    
    [SerializeField] BooSpawner _booSpawner;
    int round = 0;

    void Start()
    {
         _booSpawner = FindObjectOfType(typeof(BooSpawner))as BooSpawner;
        targetManager.onSpawnComplete.AddListener(() => StartCoroutine("WaitForNextRound"));
        StartCoroutine("WaitForNextRound");
        
        scoreText.text = "Score: ";
        
    }
    private void Update() {
        if(_booSpawner.colidiu == true){
            scoreText.text = _booSpawner.pontuacao.ToString();
            
        }
    }
    IEnumerator WaitForNextRound()
    {
        if (gameOver) yield return 0;

        round++;
        roundText.text = $"ROUND: {round}";
        roundTextGameOver.text = roundText.text;





        yield return new WaitForSeconds(delayBetweenRounds);
        NextRound();
    }

    void NextRound()
    {
        targetManager.SpawnTargets(targetsPerRound);
    }
   
}
