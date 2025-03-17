using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] hazards;
    public Vector3 spawnvalues;
    public int HarzardCount;
    public float spawnwait;
    public float startwait;
    public float wavewait;

    public GUIText ScoreText;
    public GUIText restartText;
    public GUIText GameoverText;

    private bool gameover;
    private bool restart;
    private int score;

    private void Start()
    {
        gameover = false;
        restart = false;
        restartText.text = "";
        GameoverText.text = "";

        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
    }
     void Update()
    {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startwait);
        while (true)
        {
            for (int i = 0; i < HarzardCount; i++)
            {
                GameObject hazard=hazards[Random.Range(0,hazards.Length)];
                Vector3 SpawnPosition = new Vector3(Random.Range(-spawnvalues.x, spawnvalues.x), spawnvalues.y, spawnvalues.z);
                Quaternion SpawnRotaion = Quaternion.identity;
                Instantiate(hazard, SpawnPosition, SpawnRotaion);
                yield return new WaitForSeconds(spawnwait);
            }
            yield return new WaitForSeconds(wavewait);

            if (gameover)
            {
                restartText.text = "Press 'R' For Restart";
                restart = true;
                break;

            }
        }

       
    }

    public void Addscore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    } 
    void UpdateScore()
    {
        ScoreText.text = "Score: " + score;
    }
    public void GameOver()
    {
        GameoverText.text = "Game Over!";
        gameover = true;

    }
}
