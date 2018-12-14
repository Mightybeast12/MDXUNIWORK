using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour {
    public Text ScoreBoard;
    public Text HighScore;

    public SpawnEnemiesatrandom SER;
    public int Points = 0;
    int bossspawnpoints;
    public int Highpoints;
    public int previouspoints;
    public int nextstage;
    bool runonce;
    // Use this for initialization
    void Start()
    {
        bossspawnpoints = 50;
        ScoreBoard = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>(); 

    }

    // Update is called once per frame
    void Update()
    {
        previouspoints = Points;

        ScoreBoard.text = "Score: " + Points.ToString();
        HighScore.text = "High Score: " + Highpoints.ToString();
        if (Points > nextstage)
        {
            NextStage();
        }
        if (Points >= Highpoints)
        {
            Highpoints = Points;
        }
        if (Points >= bossspawnpoints)
        {
            runonce = true;
            
          
        }
        if (runonce)
        {
            SpawnBoss();
        }

    }
    void SpawnBoss()
    {
        SER.SpawnBoss = true;
        SER.canspawn = true;        
        bossspawnpoints += 50;
        runonce = false;
    }
    void NextStage()
    {
        nextstage = previouspoints + 20;
        SER.Amountallowedtospawn++;

    }
  
}
